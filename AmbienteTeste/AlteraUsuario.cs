using Ambiente.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ambiente.Model; 

namespace AmbienteTeste
{
    public partial class AlteraUsuario : Form
    {
        string cod = null;
        public AlteraUsuario(string id)
        {
            InitializeComponent();
            cod = id;
        }

        private void tsFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AlterarSenha>().Count() > 0)
            {
                Application.OpenForms.OfType<AlterarSenha>().First().Focus();
            }
            else
            {
                AlterarSenha tela = new AlterarSenha(cod);
                tela.Show();
            }
        }

        private void AlteraUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewPerfil.perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.viewPerfil.perfil);
            UsuarioModel um = new UsuarioModel();
            
            List<string> lista=um.Dados(cod);
            
            
            maskCPF.Text = lista[0].ToString(); 
            txtCadastro.Text = lista[1].ToString();
            txtNome.Text = lista[2].ToString();
            // varre as linhas do grid...
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // varre as colunas do grid...
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    // seleciona a linha que é igual ao perfil no banco
                    if(lista[3].ToString() == row.Cells[1].Value.ToString()){
                        row.DataGridView.Select();
                    }
                }
            }
            if (lista[4].ToString() == "Ativo")
            {
                cbAtivo.Checked = true;
            }
            else
            {
                cbAtivo.Checked = false;
            }
            txtUsuario.Text = lista[5].ToString();
            txtCep.Text = lista[6].ToString();
            txtNumero.Text = lista[7].ToString();
            txtLogradouro.Text = lista[8].ToString();
            txtBairro.Text = lista[9].ToString();
            txtMunicipio.Text = lista[10].ToString();
            txtEmail.Text = lista[11].ToString();
            txtTel.Text = lista[12].ToString();
            txtCel.Text = lista[13].ToString();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            Usuario pessoa = new Usuario();
            Endereco end = new Endereco();
            Email mail = new Email();
            Telefone tel = new Telefone();

            if (cbAtivo.Checked == true)
            {
                pessoa.Status = "Ativo";
            }
            else
            {
                pessoa.Status = "Inativo";
            }
            //usuario
            pessoa.Id =Convert.ToInt32(cod);
            pessoa.Nome = txtNome.Text;
           
            //endereço
            end.Cep = txtCep.Text;
            end.Logradouro = txtLogradouro.Text;
            end.Cidade = txtMunicipio.Text;
            end.Bairro = txtBairro.Text;

            //telefone
            tel.Fixo = txtTel.Text;
            tel.Celular = txtCel.Text;

            //email
            mail.Mail = txtEmail.Text;

            try
            {
                UsuarioModel login = new UsuarioModel();
                string mensagem = login.Alterar(pessoa, end, mail, tel);
                if (mensagem != "")
                {
                    MessageBox.Show(mensagem);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Usuario pessoa = new Usuario();

            //usuario
            pessoa.Id = Convert.ToInt32(cod);

            try
            {
                UsuarioModel login = new UsuarioModel();
                string mensagem = login.Deletar(pessoa);
                if (mensagem != "")
                {
                    MessageBox.Show(mensagem);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}
