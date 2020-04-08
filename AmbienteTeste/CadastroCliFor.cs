using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ambiente.Entidade;
using Ambiente.Model;

namespace AmbienteTeste
{
    public partial class CadastroCliFor : Form
    {
        public CadastroCliFor()
        {
            InitializeComponent();
            maskCnpj.Visible = true;
            maskCpf.Visible = false;
            txtRazao.Enabled = true;
            lbFantasia.Text = "Nome Fantasia";
        }

        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {
            maskCpf.Visible = true;
            maskCnpj.Visible = false;
            txtRazao.Enabled = false;
            lbFantasia.Text = "Nome";
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            maskCnpj.Visible = true;
            maskCpf.Visible = false;
            lbFantasia.Text = "Nome Fantasia";
            txtRazao.Enabled = true;
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            CliFor cli= new CliFor();
            Endereco end = new Endereco();
            Email mail = new Email();
            Telefone tel = new Telefone();
            if (maskCpf.Visible == false)
            {
                cli.Identificacao= maskCnpj.Text;

            }
            else
            {
                
                cli.Identificacao = maskCpf.Text;
            }

            if (cbCliente.Checked == true && cbFornecedor.Checked == true)
            {
                cli.Tipo = "Cliente/Fornecedor";
            }
            else if (cbCliente.Checked == true && cbFornecedor.Checked == false)
            {
                cli.Tipo = "Cliente";
            }
            else if (cbCliente.Checked == false && cbFornecedor.Checked == true)
            {
                cli.Tipo = "Fornecedor";
            }

            
            //cliente/fornecedor
            cli.Razao = txtRazao.Text;
            cli.Fantasia = txtFantasia.Text;
            cli.Ie = txtInscEstadual.Text;
            cli.Im = txtInscMunicipal.Text;

            //endereço
            end.Cep = txtCep.Text;
            end.Logradouro = txtLogradouro.Text;
            end.Cidade = txtMunicipio.Text;
            end.Bairro = txtBairro.Text;
            end.Uf = txtUF.Text;
            end.Numero = txtNumero.Text;

            //telefone
            tel.Fixo = txtTel.Text;
            tel.Celular = txtCel.Text;

            //email
            mail.Mail = txtEmail.Text;


            try
            {
                CliForModel forn = new CliForModel();
                string mensagem = forn.salvar(cli, end, mail, tel);
                if (mensagem != "")
                {
                    MessageBox.Show(mensagem);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void tsFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpar()
        {
            txtBairro.Clear();
            txtCel.Clear();
            txtCep.Clear();
            txtEmail.Clear();
            txtLogradouro.Clear();
            txtMunicipio.Clear();
            maskCnpj.Clear();
            maskCpf.Clear();
            txtNumero.Clear();
            txtTel.Clear();
            txtUF.Clear();
            txtFantasia.Clear();
            txtInscEstadual.Clear();
            txtInscMunicipal.Clear();
            txtRazao.Clear();
        }

        private void cbFornecedor_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
