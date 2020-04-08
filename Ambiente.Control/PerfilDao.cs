using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambiente.Control
{
    public class PerfilDao
    {
        private bool var = false;
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlConnection conn = Conexao.abrirConexao();
        SqlDataReader dr;
        public bool SalvaPerfil(string nome, string permissao)
        {
            string sql = "INSERT INTO PERFIL VALUES ('"+ nome + "','" + permissao + "')";
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
        public bool DeletarPerfil(string nome)
        {
            string sql = "DELETE FROM PERFIL WHERE STR_PERFIL_PRF='" + nome + "'";
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
