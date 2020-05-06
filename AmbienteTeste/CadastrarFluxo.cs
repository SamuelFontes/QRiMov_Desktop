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

            var rg = new Regex(@"^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}\s([0-1]?[0-9]|2[0-3]):[0-5][0-9]$");
            if (rg.IsMatch(maskDt.Text))
                insert.Data = Convert.ToDateTime(maskDt.Text);
            else
            {
                MessageBox.Show("Data incorreta!");
                return;
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
                MessageBox.Show(mensagem);
                if (mensagem != "Cadastro com sucesso!")
                {
                    this.Close();
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
