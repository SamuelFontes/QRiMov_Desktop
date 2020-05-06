using Ambiente.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ambiente.Model; 

namespace AmbienteTeste
{
    public partial class AlteraUsuario : Form
    {
        string cod = null;
        public AlteraUsuario(string id)
        {
            InitializeComponent();
            cod = id;
        }

        private void tsFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AlterarSenha>().Count() > 0)
            {
                Application.OpenForms.OfType<AlterarSenha>().First().Focus();
            }
            else
            {
                AlterarSenha tela = new AlterarSenha(cod);
                tela.Show();
            }
        }

        private void AlteraUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewPerfil.perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.viewPerfil.perfil);
            UsuarioModel um = new UsuarioModel();
            
            List<string> lista=um.Dados(cod);
            
            
            txtNome.Text = lista[1].ToString();
            // varre as linhas do grid...
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // varre as colunas do grid...
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    // seleciona a linha que é igual ao perfil no banco
                    if(lista[5].ToString() == row.Cells[1].Value.ToString()){
                        row.DataGridView.Select();
                    }
                }
            }
            txtUsuario.Text = lista[3].ToString();
            txtEmail.Text = lista[4].ToString();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            Usuario pessoa = new Usuario();
            Email mail = new Email();

            //usuario
            pessoa.Id =Convert.ToInt32(cod);
            pessoa.Nome = txtNome.Text;
           
            //email
            mail.Mail = txtEmail.Text;

            try
            {
                UsuarioModel login = new UsuarioModel();
                string mensagem = login.Alterar(pessoa,  mail);
                MessageBox.Show(mensagem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Usuario pessoa = new Usuario();

            //usuario
            pessoa.Id = Convert.ToInt32(cod);

            try
            {
                UsuarioModel login = new UsuarioModel();
                string mensagem = login.Deletar(pessoa);
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
