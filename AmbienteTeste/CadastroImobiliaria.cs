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

            if (VerificarCampos())
            {
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
        private bool VerificarCampos()
        {
            string msg = "";
            //plano
            if (CmbPlano.Text == "")
                msg += "- Selecione um plano! -\n";
            //email
            var rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (!rg.IsMatch(txtEmail.Text))
                msg += " - E-mail não é valido! -\n";
            //bairro
            if (txtBairro.Text == "")
                msg += "- Preencha o Bairro! -\n";
            //cep
            rg = new Regex(@"\d{2}[.\s]?\d{3}[-.\s]?\d{3}");
            if (!rg.IsMatch(txtCep.Text))
                msg += " - CEP não é valido! -\n";
            //Logradouro
            if (txtLogradouro.Text == "")
                msg += "- Preencha o Logradouro! -\n";
            //Municipio
            if (txtMunicipio.Text == "")
                msg += "- Preencha o Municipio! -\n";
            //CNPJ
            rg = new Regex(@"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)|(^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$)");
            if (!rg.IsMatch(maskCNPJ.Text))
                msg += " - CNPJ não é valido! -\n";
            /*//CPF
            rg = new Regex(@"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)|(^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$)");
            if (!rg.IsMatch(txtCPF.Text))
                msg += " - CPF não é valido! -\n";
                */
            //Numero
            rg = new Regex(@"^\d+$");
            if (!rg.IsMatch(txtNumero.Text))
                msg += " - Número não é valido! -\n";
            //Creci
            if (txtCreci.Text == "")
                msg += "- Preencha o Creci! -\n";
            //Tel
            rg = new Regex(@"^(?:(?:\+|00)?(55)\s?)?(?:\(?([1-9][0-9])\)?\s?)?(?:((?:9\d|[2-9])\d{3})\-?(\d{4}))$");
            if (!rg.IsMatch(txtTel.Text))
                msg += " - Telefone não é valido! -\n";
            //UF
            rg = new Regex(@"^[a-zA-Z]{2}$");
            if (!rg.IsMatch(txtUF.Text))
                msg += " - UF não é valida! -\n";
            //Fantasia
            if (txtFantasia.Text == "")
                msg += "- Preencha o Nome Fantasia! -\n";
            //IE
            if (txtInscEstadual.Text == "")
                msg += "- Preencha a Inscrição Estadual! -\n";
            //IM
            if (txtInscMunicipal.Text == "")
                msg += "- Preencha a Inscrição Municipal! -\n";
            //Razao
            if (txtRazao.Text == "")
                msg += "- Preencha a Razão Social! -\n";
            MessageBox.Show(msg);
            return msg == "";
        }
    }
}