using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambiente.Entidade;

namespace Ambiente.Control
{
    public class CliForDao
    {
        private bool var = false;
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlConnection conn = Conexao.abrirConexao();
        SqlDataReader dr;



        public bool salvarCliForProc(CliFor org, Endereco end, Email mail,Telefone tel)
        {

            string sql = " InsereCliFor null,null,null,null,'" + org.Razao + "','" + org.Fantasia + "','" + org.Identificacao + "','" + org.Ie + "','" + org.Im + "','" + org.Tipo + "','" + org.Nome + "','" + end.Cep + "', '" + end.Logradouro + "','" + end.Numero + "','" + end.Bairro + "','" + end.Cidade + "','" + end.Uf + "', '" + mail.Mail + "','" + mail.DescEmail + "','" + tel.Fixo + "','" + tel.Celular + "'";
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

        public List<string> DadosCliFor(string id)
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
        public bool AlteraCliForProc(CliFor clfr, Endereco end, Email mail, Telefone tel)
        {

            string sql = " AlteraImobiliaria null,null,'" + clfr.Id + "',null,'" + clfr.Fantasia + "','" + end.Cep + "', '" + end.Logradouro + "','" + end.Numero + "','" + end.Bairro + "','" + end.Cidade + "','" + end.Uf + "', '" + mail.Mail + "','" + tel.Fixo + "','" + tel.Celular + "'";
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

        public bool DeletaCliForProc(CliFor clfr)
        {

            string sql = " DeletaImobiliaria '" + clfr.Id + "'";
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
