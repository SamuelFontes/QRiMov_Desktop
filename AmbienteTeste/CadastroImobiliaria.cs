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
        }

        private void tsFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPlano.Text == "Sem Plano")
            {
                qtd.Text = "0";
            }
            else if (CmbPlano.Text == "Silver")
            {
                qtd.Text = "15";
            }
            else if (CmbPlano.Text == "Gold")
            {
                qtd.Text = "30";
            }
            else if (CmbPlano.Text == "Platinum")
            {
                qtd.Text = "50";
            }
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
                    txtUF.Text = resultado.uf;
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
            Imobiliaria imobiliaria = new Imobiliaria();
            Endereco end = new Endereco();
            Email mail = new Email();
            Telefone tel = new Telefone();

            
            imobiliaria.Plano = CmbPlano.Text;

            //imobiliaria

            imobiliaria.Cnpj = maskCNPJ.Text;
            imobiliaria.Razao = txtRazao.Text;
            imobiliaria.Fantasia = txtFantasia.Text;
            imobiliaria.Ie = txtInscEstadual.Text;
            imobiliaria.Im = txtInscMunicipal.Text;
            imobiliaria.Creci = txtCreci.Text;

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
                ImobiliariaModel imob = new ImobiliariaModel();
                string mensagem = imob.salvar(imobiliaria, end, mail, tel);
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
            txtCNPJ.Clear();
            txtCPF.Clear();
            txtNumero.Clear();
            txtCreci.Clear();
            txtTel.Clear();
            txtUF.Clear();
            txtFantasia.Clear();
            txtInscEstadual.Clear();
            txtInscMunicipal.Clear();
            txtRazao.Clear();
        }
       
    }
}