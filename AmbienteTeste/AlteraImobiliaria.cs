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
            if (lista[0] == null)
            {
                MessageBox.Show("Este registro não existe!");
                this.Close();
                return;
            }
            if (lista[0].Length == 14)
            {
                // cpf 
                cbCPF.Checked = true;
                cbCNPJ.Checked = false;
                maskCnpj.Visible = false;
                maskCpf.Visible = true;
                txtRazao.Enabled = false;
                lbFantasia.Text = "Nome";
                maskCpf.Text = lista[0].ToString();
            }
            else
            {
                // CNPJ
                cbCNPJ.Checked = true;
                cbCPF.Checked = false;
                maskCnpj.Visible = true;
                maskCpf.Visible = false;
                lbFantasia.Text = "Nome Fantasia";
                maskCnpj.Text = lista[0].ToString();
            }
            txtRazao.Text = lista[2].ToString();
            // tipo
            if (lista[3].ToString().Contains("Cliente"))
                cbCliente.Checked = true;
            if (lista[3].ToString().Contains("Fornecedo"))
                cbFornecedor.Checked = true;
            txtFantasia.Text = lista[4].ToString();
            txtEmail.Text = lista[5].ToString();
            txtCep.Text = lista[6].ToString();
            txtNumero.Text = lista[8].ToString();
            txtLogradouro.Text = lista[7].ToString();
            txtBairro.Text = lista[9].ToString();
            cbUF.Text = lista[10].ToString();
            txtMunicipio.Text = lista[11].ToString();
            txtTel.Text = lista[12].ToString();
            txtCel.Text = lista[13].ToString();
        }

        private void tsFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            var cli = new CliFor();
            Endereco end = new Endereco();
            Email mail = new Email();
            Telefone tel = new Telefone();

            //usuario
            cli.Id = Convert.ToInt32(cod);
            if (maskCpf.Visible == false)
            {
                cli.Identificacao = maskCnpj.Text;

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
            //imobiliaria
            if (txtRazao.Enabled)
                cli.Razao = txtRazao.Text;
            else
                cli.Razao = "";
            cli.Fantasia = txtFantasia.Text;


            //endereço
            end.Cep = txtCep.Text;
            end.Logradouro = txtLogradouro.Text;
            end.Cidade = txtMunicipio.Text;
            end.Bairro = txtBairro.Text;
            end.Uf = cbUF.Text;
            end.Numero = txtNumero.Text;

            //telefone
            tel.Fixo = txtTel.Text;
            tel.Celular = txtCel.Text;

            //email
            mail.Mail = txtEmail.Text;

            try
            {
                var login = new CliForModel();
                string mensagem = login.alterar(cli, end, mail, tel);
                MessageBox.Show(mensagem);
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

        private void cbCPF_CheckedChanged(object sender, EventArgs e)
        {
            maskCpf.Visible = true;
            maskCnpj.Visible = false;
            txtRazao.Enabled = false;
            lbFantasia.Text = "Nome";
        }

        private void cbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            maskCnpj.Visible = true;
            maskCpf.Visible = false;
            lbFantasia.Text = "Nome Fantasia";
            txtRazao.Enabled = true;
        }

        
    }
}
