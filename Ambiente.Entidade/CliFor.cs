using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambiente.Entidade
{
    public class CliFor
    {
        int id;
        string nome;
        string identificacao;
        string razao;
        string fantasia;
        string ie;
        string im;
        string tipo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Identificacao { get => identificacao; set => identificacao = value; }
        public string Razao { get => razao; set => razao = value; }
        public string Fantasia { get => fantasia; set => fantasia = value; }
        public string Ie { get => ie; set => ie = value; }
        public string Im { get => im; set => im = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
