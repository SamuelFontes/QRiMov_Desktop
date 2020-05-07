using Ambiente.Entidade;
using Ambiente.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbienteTeste
{
    public partial class AlterarFluxo : Form
    {
        string cod = null;
        public AlterarFluxo(string id)
        {
            InitializeComponent();
            cod = id;
            AplicarEventos(txtValor);
        }

        private void AlterarFluxo_Load(object sender, EventArgs e)
        {
            var fluxo = new FluxoModel();

            List<string> lista = fluxo.Dados(cod);


            cbTipo.Text = lista[2].ToString();
            cbTipo_SelectedIndexChanged(sender, e);
            txtDesc.Text = lista[3].ToString();
            txtValor.Text = lista[4].ToString().Replace("R$", "").Trim();
            txtValor.Text = double.Parse(txtValor.Text).ToString("C2");
            maskDt.Text = lista[5].ToString();
            txtMov.Text = lista[6].ToString();
            cbPag.Text = lista[7].ToString();
            // varre as linhas do grid...
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // varre as colunas do grid...
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    // seleciona a linha que é igual ao perfil no banco
                    if (lista[1].ToString() == row.Cells[0].Value.ToString())
                    {
                        row.DataGridView.Select();
                    }
                }
            }
        }
        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = cbTipo.Text;
            if (result == "Entrada")
            {
                result = "%Cliente%";
            }
            else
            {
                result = "%Fornecedor%";
            }
            this.empresasTableAdapter.BuscarParametro(this.viewEmpresas.Empresas, result);
        }

        private void tsFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            Fluxo insert = new Fluxo();

            var rg = new Regex(@"^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}\s([0-1]?[0-9]|2[0-3]):[0-5][0-9]$");
            if (rg.IsMatch(maskDt.Text))
                try
                {
                    DateTimeFormatInfo brasil = new CultureInfo("pt-BR", false).DateTimeFormat;
                    insert.Data = Convert.ToDateTime(maskDt.Text, brasil);
                }
                catch
                {
                    MessageBox.Show("Data incorreta!");
                    return;
                }
            else
            {
                MessageBox.Show("Data incorreta!");
                return;
            }
            insert.Descricao = txtDesc.Text;
            insert.Tipo = cbTipo.Text;
            insert.Valor = txtValor.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim();
            int index = dataGridView1.CurrentRow.Index;
            insert.Id_empresa = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            insert.Movimento = txtMov.Text;
            insert.Pagamento = cbPag.Text;
            insert.Id = Convert.ToInt32(cod);
            try
            {
                FluxoModel fluxo = new FluxoModel();
                string mensagem = fluxo.alterar(insert);
                MessageBox.Show(mensagem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var fluxo = new Fluxo();

            //usuario
            fluxo.Id = Convert.ToInt32(cod);

            try
            {
                var login = new FluxoModel();
                string mensagem = login.deletar(fluxo);
                if (mensagem != "")
                {
                    MessageBox.Show(mensagem);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
        //campo money
        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }
        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }
        private void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }
        private void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            try
            {
                txt.Text = double.Parse(txt.Text).ToString("C2");
            }
            catch
            {
                txt.Text = "";
            }
        }
    }
}
