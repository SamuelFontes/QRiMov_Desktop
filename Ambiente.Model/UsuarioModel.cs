using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambiente.Control;
using Ambiente.Entidade;

namespace Ambiente.Model
{
    public class UsuarioModel
    {
        private string aviso = "";
        public string acessar(Usuario u)
        {
            UsuarioDao login = new UsuarioDao();

            bool valor = login.verificaLogin(u.User, u.Senha);
            if (!valor)
            {
                aviso = "Login ou senha não é válido!";
            }
            return aviso;
        }
        public string permissoes(Usuario u)
        {
            UsuarioDao login = new UsuarioDao();

            string perm = login.verificaPrermissoes(u.User, u.Senha);
            return perm;
        }
        public string salvar(Usuario u, Endereco e, Email m, Telefone t)
        {
            UsuarioDao login = new UsuarioDao();

            string aviso = null;
            if (login.salvarUsuarioProc(u, e , m, t))
            {
                aviso = "Cadastro com sucesso!";
            }
            else
            {
                aviso = "Não foi possivel cadastrar o usuário";
            }
            return aviso;
        }

        public string Alterar(Usuario u, Endereco e, Email m, Telefone t)
        {
            UsuarioDao login = new UsuarioDao();

            string aviso = null;
            if (login.AlterasuarioProc(u, e, m, t))
            {
                aviso = "Alterado com sucesso!";
            }
            else
            {
                aviso = "Não foi possivel alterar o usuário";
            }
            return aviso;
        }

        public string AlterarSenha(Usuario u, string id)
        {
            UsuarioDao login = new UsuarioDao();

            string aviso = null;
            if (login.AlteraSenha(u, id))
            {
                aviso = "Alterado com sucesso!";
            }
            else
            {
                aviso = "Não foi possivel alterar a senha";
            }
            return aviso;
        }

        public string Deletar(Usuario u)
        {
            UsuarioDao login = new UsuarioDao();

            string aviso = null;
            if (login.DeletausuarioProc(u))
            {
                aviso = "Deletado com sucesso!";
            }
            else
            {
                aviso = "Não foi possivel deletar o usuário";
            }
            return aviso;
        }

        public List<string> Dados(string id)
        {
            UsuarioDao dados = new UsuarioDao();
            List<string> lista = dados.DadosUsuarios(id);
            
            return lista;
        }
    }
}
