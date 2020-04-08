using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbienteTeste
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

        }
        private void MostrarMenu()
        {

            if (Pdrawer.Visible)
            {
                Pdrawer.Hide();
            }
            else
            {
                Pdrawer.Show();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            BuscaCliFor frmFilho = new BuscaCliFor();
            abrirTela(frmFilho);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscaImobiliaria frmFilho = new BuscaImobiliaria();
            abrirTela(frmFilho);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //  Deixa fullscreen sem cubrir a taskbar
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                var client = control as System.Windows.Forms.MdiClient;
                if (client != null)
                {
                    client.BackColor = System.Drawing.Color.LightGray;
                    break;
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscaUsuario frmFilho = new buscaUsuario();
            abrirTela(frmFilho);
        }

        private void btnParametro_Click(object sender, EventArgs e)
        {
            Parametro frmFilho = new Parametro();
            abrirTela(frmFilho);
        }

        private void TsMenu_Click(object sender, EventArgs e)
        {
            MostrarMenu();
        }
       
        private void btnFluxo_Click(object sender, EventArgs e)
        {
           var frmFilho = new FluxoCaixa();
           abrirTela(frmFilho);
        }

        private void abrirTela(Form frmNovo)
        {
            //  Fecha menu lateral e abre novo form
            MostrarMenu();
            Utilitarios utilitario = new Utilitarios();
            utilitario.criarForm(frmNovo, pnPrincipal);
        }
    }
}
