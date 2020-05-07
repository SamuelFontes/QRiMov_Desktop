using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambiente.Entidade
{
    public class Fluxo
    {
        int id;
        int id_empresa;
        string valor;
        string descricao;
        string tipo;
        string movimento;
        string pagamento;
        DateTime data;

        public int Id { get => id; set => id = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Id_empresa { get => id_empresa; set => id_empresa = value; }
        public string Movimento { get => movimento; set => movimento = value; }
        public string Pagamento { get => pagamento; set => pagamento = value; }
    }
}
