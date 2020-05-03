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
                p.Permissoes = "";
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
                if (p.Permissoes != "")
                {
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
                else
                {
                    MessageBox.Show("Pelo menos alguma permissão deve vinculada ao perfil");
                }
                this.perfilTableAdapter.Fill(this.viewPerfil.perfil);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perfil p = new Perfil();
            int index = dataGridView1.CurrentRow.Index;
            p.Id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);

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
            this.perfilTableAdapter.Fill(this.viewPerfil.perfil);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void txtNomeDeletar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
        }
    }
}
