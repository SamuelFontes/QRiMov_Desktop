using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ambiente.Control;
namespace AmbienteTeste
{
    public partial class PesquisaFluxo : AmbienteTeste.ParentPesquisa
    {
        public PesquisaFluxo()
        {
            InitializeComponent();
        }

        private void PesquisaFluxo_Load(object sender, EventArgs e)
        {
             FluxoDao fluxo = new Ambiente.Control.FluxoDao();
        }
    }
}
