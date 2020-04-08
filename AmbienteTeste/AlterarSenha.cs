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
    public partial class AlterarSenha : Form
    {
        string codigo = null;
        public AlterarSenha(string id)
        {
            InitializeComponent();
            codigo = id;
        }

        private void tsFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Length < 5 || txtConfirma.Text.Length < 5)
            {
                MessageBox.Show("Senha muito curta!");
            }
            else if (txtSenha.Text == txtConfirma.Text)
            {
                Usuario u = new Usuario();
                u.Senha=txtSenha.Text;

                try
                {
                    UsuarioModel login = new UsuarioModel();
                    string mensagem = login.AlterarSenha(u,codigo);
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
            else
            {
                MessageBox.Show("As senhas não são igual, verifique!");
            }
        }

    }
}
