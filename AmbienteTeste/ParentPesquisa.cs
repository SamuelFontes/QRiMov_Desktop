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
    public partial class ParentPesquisa : Form
    {
        public ParentPesquisa()
        {
            InitializeComponent();
        }

        protected virtual void btnPesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pai");
        }
    }
}
