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
    public partial class CadastrarFluxo : Form
    {
        public CadastrarFluxo()
        {
            InitializeComponent();
        }

        private void CadastrarFluxo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewEmpresas.Empresas'. Você pode movê-la ou removê-la conforme necessário.

            cbTipo_SelectedIndexChanged(sender,e);
        }

        private void tsFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            Fluxo insert = new Fluxo();
            if (maskDt.Text == "")
            {
                insert.Data = Convert.ToDateTime(maskDt.Text);
            }
            insert.Descricao = txtDesc.Text;
            insert.Tipo = cbTipo.Text;
            insert.Valor = Convert.ToDouble(txtValor.Text);
            int index = dataGridView1.CurrentRow.Index;
            insert.Id_empresa = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            try
            {
                FluxoModel fluxo = new FluxoModel();
                string mensagem = fluxo.salvar(insert);
                if (mensagem != "")
                {
                    MessageBox.Show(mensagem);this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = cbTipo.Text;
            if (result == "Entrada")
            {
                result = "%Cliente%";
            } else
            {
                result = "%Fornecedor%";
            }
            this.empresasTableAdapter.BuscarParametro(this.viewEmpresas.Empresas, result);
        }
    }
}
