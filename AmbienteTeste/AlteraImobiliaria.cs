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
    public partial class AlteraImobiliaria : Form
    {
        string cod = null;
        public AlteraImobiliaria(string id)
        {
            InitializeComponent();
            cod = id;
        }

        private void AlteraImobiliaria_Load(object sender, EventArgs e)
        {
            ImobiliariaModel um = new ImobiliariaModel();

            List<string> lista = um.Dados(cod);

            maskCNPJ.Text = lista[0].ToString();
            txtRazao.Text = lista[1].ToString();
            txtFantasia.Text = lista[2].ToString();
            txtEmail.Text = lista[3].ToString();
            txtCep.Text = lista[4].ToString();
            txtNumero.Text = lista[6].ToString();
            txtLogradouro.Text = lista[5].ToString();
            txtBairro.Text = lista[7].ToString();
            txtMunicipio.Text = lista[9].ToString();
            txtUF.Text = lista[8].ToString();
            txtTel.Text = lista[10].ToString();
            txtCel.Text = lista[11].ToString();
            txtCreci.Text = lista[13].ToString(); //creci
            CmbPlano.Text = lista[12].ToString();
        }

        private void tsFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            Imobiliaria imb = new Imobiliaria();
            Endereco end = new Endereco();
            Email mail = new Email();
            Telefone tel = new Telefone();

            //usuario
            imb.Id = Convert.ToInt32(cod);
            imb.Fantasia = txtFantasia.Text;

            //endereço
            end.Cep = txtCep.Text;
            end.Logradouro = txtLogradouro.Text;
            end.Cidade = txtMunicipio.Text;
            end.Bairro = txtBairro.Text;

            //telefone
            tel.Fixo = txtTel.Text;
            tel.Celular = txtCel.Text;

            //email
            mail.Mail = txtEmail.Text;

            try
            {
                ImobiliariaModel login = new ImobiliariaModel();
                string mensagem = login.alterar(imb, end, mail, tel);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            Imobiliaria imb = new Imobiliaria();

            imb.Id = Convert.ToInt32(cod);

            try
            {
                ImobiliariaModel login = new ImobiliariaModel();
                string mensagem = login.Deletar(imb);
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
