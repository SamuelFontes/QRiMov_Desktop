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
    public partial class Login : Form
    {
        
        public Login()
        {
            this.TopMost = true;
            InitializeComponent();
        }

        private void btnEntre_Click(object sender, EventArgs e)
        {
            Usuario pessoa = new Usuario();

            pessoa.User = txtLogin.Text;
            pessoa.Senha = txtSenha.Text;

            UsuarioModel login = new UsuarioModel();
            string mensagem = login.acessar(pessoa);
            if (mensagem == "Login ou senha não é válido!")
            {
                txtLogin.Text = "";
                txtSenha.Text = "";
                MessageBox.Show(mensagem);
            }
            else
            {
                panel1.Visible = true;
                timer1.Enabled = true;
                btnSair.SendToBack();
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
                
            }
            if (progressBar1.Value == 100)
            {
                Usuario pessoa = new Usuario();
                pessoa.User = txtLogin.Text;
                pessoa.Senha = txtSenha.Text;
                UsuarioModel login = new UsuarioModel();
                string param = login.permissoes(pessoa);
                Inicio frmInicial = new Inicio(param);
                frmInicial.Show(); // abre o form principal
                timer1.Stop();       // para o relógio
                this.Hide();         //fecha a janela após completar os 100%
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

       

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Usuario pessoa = new Usuario();

                pessoa.User = txtLogin.Text;
                pessoa.Senha = txtSenha.Text;

                UsuarioModel login = new UsuarioModel();
                string mensagem = login.acessar(pessoa);
                if (mensagem != "")
                {
                    MessageBox.Show(mensagem);
                }
                else
                {
                    panel1.Visible = true;
                    timer1.Enabled = true;
                    btnSair.SendToBack();
                }
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Usuario pessoa = new Usuario();

                pessoa.User = txtLogin.Text;
                pessoa.Senha = txtSenha.Text;

                UsuarioModel login = new UsuarioModel();
                string mensagem = login.acessar(pessoa);
                if (mensagem != "")
                {
                    MessageBox.Show(mensagem);
                }
                else
                {
                    panel1.Visible = true;
                    timer1.Enabled = true;
                    btnSair.SendToBack();
                }
            }
        }
    }
}
