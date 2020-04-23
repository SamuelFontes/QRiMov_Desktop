using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Configuration;
using Ambiente;
namespace Ambiente.Control
{
    public class Conexao
    {
        private static string conexao = ConfigurationManager.ConnectionStrings["qrimov"].ConnectionString;
        private static SqlConnection conn = null;
        
        public static SqlConnection abrirConexao()
        {
            conn = new SqlConnection(conexao);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                conn = null;
                
            }
            return conn;
        }
        public static void fechaConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
