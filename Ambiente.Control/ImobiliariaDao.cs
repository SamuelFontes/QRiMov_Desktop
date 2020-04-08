using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Ambiente.Entidade;

namespace Ambiente.Control
{
    public class ImobiliariaDao
    {
        private bool var = false;
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlConnection conn = Conexao.abrirConexao();
        SqlDataReader dr;

       

        public bool salvarImobiliariaProc(Imobiliaria imb, Endereco end, Email mail, Telefone tel)
        {

            string sql = " InsereImobiliaria null,null,null,null,'" + imb.Razao + "','" + imb.Fantasia + "','" + imb.Cnpj + "','" + imb.Ie + "','" + imb.Im + "','" + imb.Creci + "','" + end.Cep + "', '" + end.Logradouro + "','" + end.Numero + "','" + end.Bairro + "','" + end.Cidade + "','" + end.Uf + "', '" + mail.Mail + "','" + mail.DescEmail + "','" + tel.Fixo + "','" + tel.Celular + "','"+imb.Plano+"'";
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

        public List<string> DadosImobiliaria(string id)
        {
            string sql = "SELECT * FROM view_org WHERE int_id_org='" + id + "';";

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
                    lista.Add(dr["str_plano_org"].ToString());
                    lista.Add(dr["str_creci_org"].ToString());
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
        public bool AlteraImobiliariaProc(Imobiliaria imb, Endereco end, Email mail, Telefone tel)
        {

            string sql = " AlteraImobiliaria null,null,'" + imb.Id + "',null,'" + imb.Fantasia + "','" + end.Cep + "', '" + end.Logradouro + "','" + end.Numero + "','" + end.Bairro + "','" + end.Cidade + "','" + end.Uf + "', '" + mail.Mail + "','" + tel.Fixo + "','" + tel.Celular + "','" + imb.Plano + "'";
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

        public bool DeletaImobiliariaProc(Imobiliaria imb)
        {

            string sql = "exec deletaImobiliaria " + imb.Id.ToString() ;
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
