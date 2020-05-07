using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambiente.Entidade;
using Ambiente.Control;
using System.Text.RegularExpressions;

namespace Ambiente.Model
{
    public class FluxoModel
    {
        private string aviso = "";

        public string salvar(Fluxo f)
        {
            FluxoDao login = new FluxoDao();

            string aviso = verificar(f);
            if (aviso == "") { 
                if (login.salvar(f))
                {
                    aviso = "Cadastro com sucesso!";
                }
                else
                {
                    aviso = "Erro ao cadastrar!";
                }
            }
            return aviso;
        }

        public string deletar(Fluxo f)
        {
            FluxoDao login = new FluxoDao();
            string aviso = null;
            if (login.Deletar(f))
            {
                aviso = "Excluído com sucesso!";
            }
            else
            {
                aviso = "Não foi possivel excluir!";
            }
            return aviso;
        }

        public string alterar(Fluxo f)
        {
            FluxoDao login = new FluxoDao();

            string aviso = verificar(f);
            if (aviso == "")
            {
                if (login.Alterar(f))
                {
                    aviso = "Alterado com sucesso!";
                }
                else
                {
                    aviso = "Não foi possivel alterar!";
                }
            }
            return aviso;
        }

        public List<string> Dados(string id)
        {
            FluxoDao dados = new FluxoDao();
            List<string> lista = dados.Dados(id);

            return lista;
        }
        private string verificar(Fluxo f)
        {
            string msg = "";
            //tipo
            if (f.Tipo == "")
                msg += "- Tipo Incorreto!? -\n";

            
            //mov
            if (f.Movimento == "")
                msg += "- Defina o tipo de movimento! -\n";
            //pag
            if (f.Pagamento == "")
                msg += "- Defina o tipo de pagamento! -\n";
            return msg;
        }
    }
}
