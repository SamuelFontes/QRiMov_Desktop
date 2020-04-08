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
using Ambiente.Model;

namespace AmbienteTeste
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void tsFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            Usuario pessoa = new Usuario();
            Endereco end = new Endereco();
            Email mail = new Email();
            Telefone tel = new Telefone();

            pessoa.Perfil=dataGridView1.CurrentRow.Cells[1].Value.ToString();
                       
            if (cbAtivo.Checked == true)
            {
                pessoa.Status = "Ativo";
            }
            else
            {
                pessoa.Status = "Inativo";
            }
            //usuario

            pessoa.User = txtUsuario.Text;
            pessoa.Senha = txtSenha.Text;
            pessoa.Cpf = maskCPF.Text;
            pessoa.Nome = txtNome.Text;
            DateTime d = Convert.ToDateTime(maskDtNascimento.Text);
            pessoa.Dtnascimento = d.ToString("yyyy-MM-dd");

            //endereço
            end.Cep = txtCep.Text;
            end.Logradouro = txtLogradouro.Text;
            end.Cidade = txtMunicipio.Text;
            end.Bairro = txtBairro.Text;
            end.Uf = txtUF.Text;

            //telefone
            tel.Fixo = txtTel.Text;
            tel.Celular = txtCel.Text;

            //email
            mail.Mail = txtEmail.Text;


            try
            {
                UsuarioModel login = new UsuarioModel();
                string mensagem = login.salvar(pessoa, end, mail, tel);
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
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (!rg.IsMatch(email))
            {
                MessageBox.Show("E-mail não é valido!");
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
            txtNome.Clear();
            txtNumero.Clear();
            txtSenha.Clear();
            txtTel.Clear();
            txtUF.Clear();
            txtUsuario.Clear();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewPerfil.perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.viewPerfil.perfil);
           
        }
    }
}
