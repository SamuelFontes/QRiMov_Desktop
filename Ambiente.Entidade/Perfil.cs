using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambiente.Entidade
{
    public class Perfil
    {
        int id;
        string nome;
        string permissoes;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Permissoes { get => permissoes; set => permissoes = value; }
    }
}
