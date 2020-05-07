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
using Ambiente.Entidade;
using Ambiente.Model;
namespace AmbienteTeste
{
    public partial class CadastrarFluxo : Form
    {
        public CadastrarFluxo()
        {
            InitializeComponent();
            AplicarEventos(txtValor);
        }

        private void CadastrarFluxo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewEmpresas.Empresas'. Você pode movê-la ou removê-la conforme necessário.
            
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
            try
            {
                FluxoModel fluxo = new FluxoModel();
                string mensagem = fluxo.salvar(insert);
                MessageBox.Show(mensagem);
                if (mensagem == "Cadastro com sucesso!")
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = cbTipo.Text;
            if (result == "Entrada")
            {
                result = "%Cliente%";
            } else
            {
                result = "%Fornecedor%";
            }
            this.empresasTableAdapter.BuscarParametro(this.viewEmpresas.Empresas, result);
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {
            
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
