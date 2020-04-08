using Ambiente.Entidade;
using Ambiente.Control;
using System.Collections.Generic;

namespace Ambiente.Model
{
    public class ImobiliariaModel
    {
        private string aviso = "";

        public string salvar(Imobiliaria i, Endereco e, Email m, Telefone t)
        {
            ImobiliariaDao login = new ImobiliariaDao();

            string aviso = null;
            if (login.salvarImobiliariaProc(i, e, m, t))
            {
                aviso = "Cadastro com sucesso!";
            }
            else
            {
                aviso = "Não foi possivel cadastrar a imobiliária";
            }
            return aviso;
        }

        public string alterar(Imobiliaria i, Endereco e, Email m, Telefone t)
        {
            ImobiliariaDao login = new ImobiliariaDao();

            string aviso = null;
            if (login.AlteraImobiliariaProc(i, e, m, t))
            {
                aviso = "Alterado com sucesso!";
            }
            else
            {
                aviso = "Não foi possivel alterar a imobiliária";
            }
            return aviso;
        }

        public string Deletar(Imobiliaria i)
        {
            ImobiliariaDao login = new ImobiliariaDao();

            string aviso = null;
            if (login.DeletaImobiliariaProc(i))
            {
                aviso = "Excluído com sucesso!";
            }
            else
            {
                aviso = "Não foi possivel excluír a imobiliária";
            }
            return aviso;
        }

        public List<string> Dados(string id)
        {
            ImobiliariaDao dados = new ImobiliariaDao();
            List<string> lista = dados.DadosImobiliaria(id);

            return lista;
        }
    }
}

