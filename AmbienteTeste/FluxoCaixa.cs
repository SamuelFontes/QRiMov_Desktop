using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            this.saldo_bancarioTableAdapter.Fill(this.viewFinancas.saldo_bancario);
            calcularSaldo();
            // TODO: esta linha de código carrega dados na tabela 'viewFinancas.saldo_bancario'. Você pode movê-la ou removê-la conforme necessário.
            /*this.saldo_bancarioTableAdapter.Fill(this.viewFinancas.saldo_bancario);
             // TODO: esta linha de código carrega dados na tabela 'viewFinancas.saldo_bancario'. Você pode movê-la ou removê-la conforme necessário.
             this.saldo_bancarioTableAdapter.Fill(this.viewFinancas.saldo_bancario);
             this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
             this.FormBorderStyle = FormBorderStyle.None;
            var dt = new DataTable();
             var ws = new TesteWS.WebService1SoapClient();
             dt = ws.GetDataSet("select * from caracteristicas", "qrimov"); */
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.saldo_bancarioTableAdapter.Fill(this.viewFinancas.saldo_bancario);
            calcularSaldo();
            string result = "%" + txtBusca.Text + "%";
            this.saldo_bancarioTableAdapter.BuscarParametro(this.viewFinancas.saldo_bancario, result);
        }
        private void calcularSaldo()
        {
            double valorTotal = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                double valorAtual = double.Parse(row.Cells[2].Value.ToString().Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(), CultureInfo.InvariantCulture);
                if (row.Cells[4].Value.ToString() == "Entrada")
                {
                    valorTotal += valorAtual;
                }
                else
                {
                    valorTotal -= valorAtual;
                }
            }
            lbSaldo.Text = double.Parse(valorTotal.ToString()).ToString("C2");
        }
    }
}
