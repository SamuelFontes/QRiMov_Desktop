using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambiente.Entidade
{
    public class Endereco
    {
        int id;
        string cep;
        string logradouro;
        string bairro;
        string cidade;
        string uf;
        string numero;

        public int Id { get => id; set => id = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Numero { get => numero; set => numero = value; }
    }
}
