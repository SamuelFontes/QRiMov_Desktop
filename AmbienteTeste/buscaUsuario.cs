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
    public partial class buscaUsuario : Form
    {
        public buscaUsuario()
        {
            InitializeComponent();
        }

        private void tsFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var frmAdd = new CadastroUsuario();
            var utilitario = new Utilitarios();
            utilitario.criarForm(frmAdd);
        }

        private void buscaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewUsuarioDataSet.view_usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.view_usuariosTableAdapter.Busca(this.viewUsuarioDataSet.view_usuarios);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
                string result = "%" + txtBusca.Text + "%";
                this.view_usuariosTableAdapter.BuscaParametro(this.viewUsuarioDataSet.view_usuarios, result);
        }

        private void txtBusca_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBusca.Text.Length == 0) {
                this.view_usuariosTableAdapter.Busca(this.viewUsuarioDataSet.view_usuarios);
            }
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string id= dataGridView1.Rows[index].Cells[0].Value.ToString();
            
            var frmAdd = new AlteraUsuario(id);
            var utilitario = new Utilitarios();
            utilitario.criarForm(frmAdd);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.view_usuariosTableAdapter.Busca(this.viewUsuarioDataSet.view_usuarios);
        }
    }
}
