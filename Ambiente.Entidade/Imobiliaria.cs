using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambiente.Entidade
{
    public class Imobiliaria
    {
        int id;
        string cnpj;
        string fantasia;
        string razao;
        string ie;
        string im;
        string plano;
        string creci;

        public int Id { get => id; set => id = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Fantasia { get => fantasia; set => fantasia = value; }
        public string Razao { get => razao; set => razao = value; }
        public string Ie { get => ie; set => ie = value; }
        public string Im { get => im; set => im = value; }
        public string Plano { get => plano; set => plano = value; }
        public string Creci { get => creci; set => creci = value; }
    }
}
