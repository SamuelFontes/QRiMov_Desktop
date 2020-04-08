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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewFinancas.saldo_bancario'. Você pode movê-la ou removê-la conforme necessário.
            this.saldo_bancarioTableAdapter.Fill(this.viewFinancas.saldo_bancario);

        }
    }
}
