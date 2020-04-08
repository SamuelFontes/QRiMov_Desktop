using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AmbienteTeste
{
    class Utilitarios
    {

        public void criarForm(Form frmNovo, Panel pnPrincipal)
        {
            //  Cria um form novo dentro de um panel
            frmNovo.TopLevel = false;
            if (pnPrincipal.Controls.Count != 0)
            {
                pnPrincipal.Controls.RemoveAt(0);
            }
            pnPrincipal.Controls.Add(frmNovo);
            frmNovo.FormBorderStyle = FormBorderStyle.None;
            frmNovo.WindowState = FormWindowState.Maximized;
            frmNovo.Show();
        }

        public void criarForm(Form frmNovo)
        {
            //  Cria um form novo dentro de um panel
            string type = frmNovo.GetType().BaseType.Name;
            frmNovo.FormBorderStyle = FormBorderStyle.None;
            frmNovo.StartPosition = FormStartPosition.CenterScreen;
            frmNovo.ShowDialog();
        }
    }
}
