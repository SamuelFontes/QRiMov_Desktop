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
        double valor;
        string descricao;
        string tipo;
        DateTime data;

        public int Id { get => id; set => id = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Id_empresa { get => id_empresa; set => id_empresa = value; }
    }
}
