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
    public partial class Parametro : Form
    {
        public Parametro()
        {
            InitializeComponent();
        }

        private void Parametro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewPerfil.perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.viewPerfil.perfil);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perfil p = new Perfil();

            if (txtNome.Text == "")
            {
                MessageBox.Show("Cadastro inválido!\nVerifique os campos");
            }
            else { 
                p.Nome = txtNome.Text;

                if (cbCliFor.Checked == true){
                    p.Permissoes = cbCliFor.Text;
                }
                if (cbFinanceiro.Checked == true)
                {
                    p.Permissoes +=" " + cbFinanceiro.Text;
                }
                if (cbImobiliaria.Checked == true)
                {
                    p.Permissoes += " " + cbImobiliaria.Text;
                }
                if (cbUsuario.Checked == true)
                {
                    p.Permissoes += " " + cbUsuario.Text;
                }
               
                try
                {
                    PerfilModel perfil = new PerfilModel();
                    string mensagem = perfil.salvar(p);
                    if (mensagem != "")
                    {
                        MessageBox.Show(mensagem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perfil p = new Perfil();
            p.Nome = txtNomeDeletar.Text;

            try
            {
                PerfilModel perfil = new PerfilModel();
                string mensagem = perfil.Deletar(p);
                if (mensagem != "")
                {
                    MessageBox.Show(mensagem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}
