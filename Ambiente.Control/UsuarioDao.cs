using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambiente.Entidade;

namespace Ambiente.Control
{
    public class UsuarioDao
    {
        private bool var = false;
        private string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlConnection conn = Conexao.abrirConexao();
        SqlDataReader dr;

        public bool verificaLogin(string login, string senha)
        {
            cmd.CommandText = "select * from USUARIO where str_login_usr=@user and str_senha_usr=@password";
            cmd.Parameters.AddWithValue("@user", login);
            cmd.Parameters.AddWithValue("@password", senha);
            try
            {
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    var = true;
                    mensagem = "Login encontrado";
                }
                else
                {
                    mensagem = "Login não encontrado!";
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro: " + ex;
            }
            return var;
        }
        public string verificaPrermissoes(string login, string senha)
        {
            string param = "";
            cmd.CommandText = "SELECT P.STR_DESCRICAO_PRF FROM PERFIL P,USUARIO U, LINK_PRF_USR L " +
                "WHERE U.INT_ID_USR = L.INT_ID_USR AND L.INT_ID_PRF = P.INT_ID_PRF and u.str_login_usr=@user " +
                "and u.str_senha_usr=@password";
            cmd.Parameters.AddWithValue("@user", login);
            cmd.Parameters.AddWithValue("@password", senha);
            try
            {
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        param += String.Format("{0}", dr[0]);
                    }
                    mensagem = "Login encontrado";
                }
                else
                {
                    mensagem = "Login não encontrado!";
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro: " + ex;
            }
            return param;
        }

        /* public bool salvarUsuario(Usuario dados){

             string sql = "INSERT INTO USUARIO  VALUES ('" + dados.Nome + "','" + dados.Status + "','" + dados.Cpf + "','" + dados.Dtnascimento + "', getdate() ,'" + dados.User + "','" + dados.Senha + "');";

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
         }*/

        public bool salvarUsuarioProc(Usuario usr,Endereco end, Email mail, Telefone tel)
        {

            string sql = " InsereUsuario null,null,null,null,'" + usr.Nome + "','" + usr.Status + "','" + usr.Cpf + "','" + usr.Dtnascimento + "','" + usr.User + "','" + usr.Senha + "','" + end.Cep + "', '" + end.Logradouro + "','" + end.Numero + "','" + end.Bairro + "','" + end.Cidade + "','" + end.Uf + "', '" + mail.Mail + "','" + mail.DescEmail + "','" + tel.Fixo + "','" + tel.Celular + "','" + usr.Perfil+ "',null";
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

        public bool AlterasuarioProc(Usuario usr, Endereco end, Email mail, Telefone tel)
        {

            string sql = " AlteraUsuario null,null,'"+usr.Id+"',null,null,'" + usr.Nome + "','" + usr.Status + "','" + end.Cep + "', '" + end.Logradouro + "','" + end.Numero + "','" + end.Bairro + "','" + end.Cidade + "','" + end.Uf + "', '" + mail.Mail + "','" + tel.Fixo + "','" + tel.Celular + "','" + usr.Perfil + "'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    var = true;
                    Console.WriteLine(sql);
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
        public bool AlteraSenha(Usuario usr, string id)
        {

            string sql = "UPDATE USUARIO SET str_senha_usr='"+usr.Senha+"' where int_id_usr='"+id+"'";
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

        public bool DeletausuarioProc(Usuario usr)
        {

            string sql = " DeletaUsuario '" + usr.Id + "'";
            Console.WriteLine(sql);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    var = true;
                    Console.WriteLine(sql);
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

        public List<string> DadosUsuarios(string id)
        {
            string sql = "SELECT * FROM view_usuarios WHERE int_id_usr='" + id + "';";

            List<string> lista = new List<string>();

            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add( dr["str_cpf_usr"].ToString());
                    lista.Add( dr["dt_cadastro_usr"].ToString());
                    lista.Add( dr["str_nome_usr"].ToString());
                    lista.Add( dr["str_perfil_prf"].ToString());
                    lista.Add( dr["str_status_usr"].ToString());
                    lista.Add( dr["str_login_usr"].ToString());
                    lista.Add( dr["str_cep_end"].ToString());
                    lista.Add( dr["str_numero_end"].ToString());
                    lista.Add( dr["str_logradouro_end"].ToString());
                    lista.Add( dr["str_bairro_end"].ToString());
                    lista.Add( dr["str_comarca_end"].ToString());
                    lista.Add( dr["str_email_mail"].ToString());
                    lista.Add( dr["str_telefone_tel"].ToString());
                    lista.Add( dr["str_celular_tel"].ToString());
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
    }
}
