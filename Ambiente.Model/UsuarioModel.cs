using Ambiente.Control;
using Ambiente.Entidade;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
        public string salvar(Usuario u,Email m)
        {
            UsuarioDao login = new UsuarioDao();

            string aviso = verificarCampos(u,  m);
            if (aviso == "")
            { 
                if (login.salvarUsuarioProc(u, m))
                {
                    aviso = "Cadastro com sucesso!";
                }
                else
                {
                    aviso = "Não foi possivel cadastrar o usuário";
                }
            }
            return aviso;
        }

        public string Alterar(Usuario u,Email m)
        {
            UsuarioDao login = new UsuarioDao();
            string aviso = verificarCampos(u, m);
            if (aviso == "")
            {
                if (login.AlterasuarioProc(u, m))
                {
                    aviso = "Alterado com sucesso!";
                }
                else
                {
                    aviso = "Não foi possivel alterar o usuário";
                }
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
        private string verificarCampos(Usuario pessoa, Email mail)
        {
            string msg = "";

            if (pessoa.Perfil=="")
                msg += "- Selecione um Perfil! -\n";
            //usuario
            if (pessoa.User == "")
                msg += "- Preencha o campo Usuário! -\n";
            if (pessoa.Senha == "")
                msg += "- Preencha o campo Senha! -\n";
            if(pessoa.Senha != null)
                if (pessoa.Senha.Length<5)
                    msg += "- Senha muito curta! -\n";
            if (pessoa.Nome == "")
                msg += "- Preencha o campo Nome! -\n";
            //email
            var rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (!rg.IsMatch(mail.Mail))
                msg += " - E-mail não é valido! -\n";
            return msg;
        }
    }
}
