using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambiente.Entidade
{
    public class Telefone
    {
        int id;
        string fixo;
        string celular;

        public int Id { get => id; set => id = value; }
        public string Fixo { get => fixo; set => fixo = value; }
        public string Celular { get => celular; set => celular = value; }
    }
}
