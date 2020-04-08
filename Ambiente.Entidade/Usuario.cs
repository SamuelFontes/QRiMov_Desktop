using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambiente.Entidade
{
    public class Usuario
    {
        private int id;
        private string user;
        private string senha;
        private string cpf;
        private string nome;
        private string status;
        private string dtnascimento;
        private string dtcadastro;
        string perfil;


        public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Status { get => status; set => status = value; }
        public string Dtcadastro { get => dtcadastro; set => dtcadastro = value; }
        public string Dtnascimento { get => dtnascimento; set => dtnascimento = value; }
        public string Perfil { get => perfil; set => perfil = value; }
    }
    
}
