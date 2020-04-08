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
    public partial class FluxoCaixa : Form
    {
        public FluxoCaixa()
        {
            InitializeComponent();
        }

        private void FluxoCaixa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewFinancas.saldo_bancario'. Você pode movê-la ou removê-la conforme necessário.
            this.saldo_bancarioTableAdapter.Fill(this.viewFinancas.saldo_bancario);
            // TODO: esta linha de código carrega dados na tabela 'viewFinancas.saldo_bancario'. Você pode movê-la ou removê-la conforme necessário.
            this.saldo_bancarioTableAdapter.Fill(this.viewFinancas.saldo_bancario);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void vieworgBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

       

        private void txtBusca_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBusca.Text.Length == 0)
            {
                this.saldo_bancarioTableAdapter.Fill(this.viewFinancas.saldo_bancario);
            }
            else
            {
                string result = "%" + txtBusca.Text + "%";
                this.saldo_bancarioTableAdapter.BuscarParametro(this.viewFinancas.saldo_bancario, result);
            }
        }

        private void tsFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var frmAdd = new CadastrarFluxo();
            var utilitario = new Utilitarios();
            utilitario.criarForm(frmAdd);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            var frmAlt = new AlterarFluxo(id);
            var utilitario = new Utilitarios();
            utilitario.criarForm(frmAlt);
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string result = "%" + txtBusca.Text + "%";
            this.saldo_bancarioTableAdapter.BuscarParametro(this.viewFinancas.saldo_bancario, result);
        }
    }
}
