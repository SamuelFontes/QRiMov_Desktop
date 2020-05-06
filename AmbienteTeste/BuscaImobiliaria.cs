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

namespace AmbienteTeste
{
    public partial class BuscaImobiliaria : Form
    {
        public BuscaImobiliaria()
        {
            InitializeComponent();
        }   

        private void CadastroImob_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewCliForDataSet.view_org'. Você pode movê-la ou removê-la conforme necessário.
            this.view_orgTableAdapter1.Fill(this.viewCliForDataSet.view_org);

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            string result = "%" + txtBusca.Text + "%";
            this.view_orgTableAdapter1.BuscaParametro(this.viewCliForDataSet.view_org, result);

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var frmAdd = new CadastroImobiliaria();
            var utilitario = new Utilitarios();
            utilitario.criarForm(frmAdd);

        }

        private void txtBusca_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBusca.Text.Length == 0)
            {
                string result = "%" + txtBusca.Text + "%";
                this.view_orgTableAdapter1.BuscaParametro(this.viewCliForDataSet.view_org, result);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string result = "%" + txtBusca.Text + "%";
            this.view_orgTableAdapter1.BuscaParametro(this.viewCliForDataSet.view_org, result);
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string result = "%" + txtBusca.Text + "%";
            this.view_orgTableAdapter1.BuscaParametro(this.viewCliForDataSet.view_org, result);
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            var frmAdd = new AlteraImobiliaria(id);
            var utilitario = new Utilitarios();
            utilitario.criarForm(frmAdd);
        }

        
    }
}
