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
            sql = "INSERT INTO FLUXO_CAIXA VALUES ("+f.Id_empresa.ToString() + ", '"+f.Tipo
                + "', '" + f.Descricao
                + "', " + f.Valor.ToString()
                + ",'" + f.Data.ToString("yyyy-MM-dd HH:mm:ss.fff")
                + "', '" + f.Movimento
                + "', '"+ f.Pagamento+"')";
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
                MessageBox.Show("Erro ao inserir, favor verificar se os campos foram preenchidos corretamente.");
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }

        public List<string> Dados(string id)
        {
            string sql = "SELECT * FROM FLUXO_CAIXA WHERE INT_ID_FLUXO =  " + id.ToString() + ";";
            Console.WriteLine(sql);
            List<string> lista = new List<string>();

            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["INT_ID_FLUXO"].ToString());
                    lista.Add(dr["INT_ID_ORG"].ToString());
                    lista.Add(dr["STR_TIPO_FLUXO"].ToString());
                    lista.Add(dr["STR_DESCRICAO_FLUXO"].ToString());
                    lista.Add(dr["STR_VALOR_FLUXO"].ToString());
                    lista.Add(dr["DT_DATA_FLUXO"].ToString());
                    lista.Add(dr["STR_MOVIMENTO_FLUXO"].ToString());
                    lista.Add(dr["STR_PAGAMENTO_FLUXO"].ToString());
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

            string sql = "UPDATE FLUXO_CAIXA SET INT_ID_ORG = " + f.Id_empresa.ToString() + ", STR_TIPO_FLUXO =  '" + f.Tipo
                + "', STR_DESCRICAO_FLUXO =  '" + f.Descricao
                + "', STR_VALOR_FLUXO =  " + f.Valor.ToString()
                + ", DT_DATA_FLUXO = '" + f.Data.ToString("yyyy-MM-dd HH:mm:ss.fff")
                + "', STR_MOVIMENTO_FLUXO =  '" + f.Movimento
                + "', STR_PAGAMENTO_FLUXO =  '" + f.Pagamento + "' WHERE INT_ID_FLUXO = "+f.Id.ToString();
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

            string sql = "DELETE FROM FLUXO_CAIXA WHERE INT_ID_FLUXO =" + f.Id.ToString();
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
