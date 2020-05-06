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
            Email mail = new Email();

            pessoa.Perfil=dataGridView1.CurrentRow.Cells[1].Value.ToString();
                       
            //usuario

            pessoa.User = txtUsuario.Text;
            pessoa.Senha = txtSenha.Text;
            pessoa.Nome = txtNome.Text;


            //email
            mail.Mail = txtEmail.Text;


            try
            {
                UsuarioModel login = new UsuarioModel();
                string mensagem = login.salvar(pessoa, mail);
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



        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewPerfil.perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.viewPerfil.perfil);
           
        }
    }
}
