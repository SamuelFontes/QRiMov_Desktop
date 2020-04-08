using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ambiente.Entidade;

namespace Ambiente.Control
{
    public class FluxoDao
    {
        private bool var = false;
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlConnection conn = Conexao.abrirConexao();
        SqlDataReader dr;



        public bool salvar(Fluxo f)
        {
            string sql = "";
           // string sql = "INSERT INTO FLUXO_CAIXA VALUES("+f.Id_empresa.ToString()+",'"+f.Tipo+
           //     "','"+f.Descricao+"','"+f.Valor.ToString()"','" + f.Data.ToString("yyyy/MM/dd HH:mm:ss")+"')";
            Console.WriteLine(sql);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    var = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("erro: " + ex.ToString());
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }

        public List<string> Dados(string id)
        {
            string sql = "SELECT * FROM view_CliFor WHERE int_id_org='" + id + "';";
            Console.WriteLine(sql);
            List<string> lista = new List<string>();

            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["str_identificao_org"].ToString());
                    lista.Add(dr["str_razao_org"].ToString());
                    lista.Add(dr["str_fantasia_org"].ToString());
                    lista.Add(dr["str_email_mail"].ToString());
                    lista.Add(dr["str_cep_end"].ToString());
                    lista.Add(dr["str_logradouro_end"].ToString());
                    lista.Add(dr["str_numero_end"].ToString());
                    lista.Add(dr["str_bairro_end"].ToString());
                    lista.Add(dr["str_uf_end"].ToString());
                    lista.Add(dr["str_comarca_end"].ToString());
                    lista.Add(dr["str_telefone_tel"].ToString());
                    lista.Add(dr["str_celular_tel"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("erro: " + ex.ToString());
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return lista;
        }
        public bool Alterar(Fluxo f)
        {

            string sql = "UPDATE";
            Console.WriteLine(sql);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    var = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("erro: " + ex.ToString());
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }

        public bool Deletar(Fluxo f)
        {

            string sql = "DELETE";
            Console.WriteLine(sql);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    var = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("erro: " + ex.ToString());
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }
    }
}
