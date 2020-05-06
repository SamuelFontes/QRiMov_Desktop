using Ambiente.Entidade;
using Ambiente.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void AlterarFluxo_Load(object sender, EventArgs e)
        {
            var fluxo = new FluxoModel();

            List<string> lista = fluxo.Dados(cod);


            cbTipo.Text = lista[2].ToString();
            cbTipo_SelectedIndexChanged(sender, e);
            txtDesc.Text = lista[3].ToString();
            txtValor.Text = lista[4].ToString();
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
            var fluxo = new Fluxo();

            //usuario
            fluxo.Id = Convert.ToInt32(cod);
            /*pessoa.Nome = txtNome.Text;

            //email
            mail.Mail = txtEmail.Text;

            try
            {
                UsuarioModel login = new UsuarioModel();
                string mensagem = login.Alterar(pessoa, mail);
                MessageBox.Show(mensagem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }*/
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
    }
}
