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
    public partial class AlterarFluxo : Form
    {
        string cod = null;
        public AlterarFluxo(string id)
        {
            InitializeComponent();
            cod = id;
        }

        private void AlterarFluxo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewEmpresas.Empresas'. Você pode movê-la ou removê-la conforme necessário.

        }
    }
}
