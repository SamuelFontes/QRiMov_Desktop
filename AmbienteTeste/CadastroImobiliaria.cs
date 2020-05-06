using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ambiente.Entidade;
using Correios.Net;
using Ambiente.Model;

namespace AmbienteTeste
{
    public partial class CadastroImobiliaria : Form
    {
        public CadastroImobiliaria()
        {
            InitializeComponent();
            maskCnpj.Visible = true;
            maskCpf.Visible = false;
            txtRazao.Enabled = true;
            lbFantasia.Text = "Nome Fantasia";
        }

        private void tsFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void txtCep_Leave(object sender, EventArgs e)
        {
            _LocalizaCEP();
        }



        private void _LocalizaCEP()
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(txtCep.Text);
                    txtLogradouro.Text = resultado.end;
                    txtMunicipio.Text = resultado.cidade;
                    txtBairro.Text = resultado.bairro;
                    cbUF.Text = resultado.uf;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    // TODO colocar uma identificação visual que não achou cep
                }
            }
        }

        

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            CliFor cli = new CliFor();
            Endereco end = new Endereco();
            Email mail = new Email();
            Telefone tel = new Telefone();


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
                var imob = new CliForModel();
                string mensagem = imob.salvar(cli, end, mail, tel);
                MessageBox.Show(mensagem);
                if (mensagem == "Cadastro com sucesso!")
                        this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void Limpar()
        {
            txtBairro.Clear();
            txtCel.Clear();
            txtCep.Clear();
            txtEmail.Clear();
            txtLogradouro.Clear();
            txtMunicipio.Clear();
            txtNumero.Clear();
            txtTel.Clear();
            txtFantasia.Clear();
            txtRazao.Clear();
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