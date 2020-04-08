using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambiente.Entidade;
using Ambiente.Control;

namespace Ambiente.Model
{
    public class CliForModel
    {
        private string aviso = "";

        public string salvar(CliFor c, Endereco e, Email m, Telefone t)
        {
            CliForDao login = new CliForDao();

            string aviso = null;
            if (login.salvarCliForProc(c, e, m, t))
            {
                aviso = "Cadastro com sucesso!";
            }
            else
            {
                aviso = "Não foi possivel cadastrar o cliente ou fonecedor";
            }
            return aviso;
        }

        public string deletar(CliFor c)
        {
            CliForDao login = new CliForDao();

            string aviso = null;
            if (login.DeletaCliForProc(c))
            {
                aviso = "Excluído com sucesso!";
            }
            else
            {
                aviso = "Não foi possivel excluir o cliente ou fonecedor";
            }
            return aviso;
        }

        public string alterar(CliFor c, Endereco e, Email m, Telefone t)
        {
            CliForDao login = new CliForDao();

            string aviso = null;
            if (login.AlteraCliForProc(c, e, m, t))
            {
                aviso = "Alterado com sucesso!";
            }
            else
            {
                aviso = "Não foi possivel alterar o cliente ou fonecedor";
            }
            return aviso;
        }

        public List<string> Dados(string id)
        {
            CliForDao dados = new CliForDao();
            List<string> lista = dados.DadosCliFor(id);

            return lista;
        }
    }
}
