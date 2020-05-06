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
    public class CliForModel
    {
        private string aviso = "";

        public string salvar(CliFor c, Endereco e, Email m, Telefone t)
        {
            CliForDao login = new CliForDao();

            string aviso = VerificarCampos(c, e, m, t);
            if (aviso == "")
            {
                if (login.salvarCliForProc(c, e, m, t))
                {
                    aviso = "Cadastro com sucesso!";
                }
                else
                {
                    aviso = "Não foi possivel cadastrar o cliente ou fonecedor";
                }
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

            string aviso = VerificarCampos(c, e, m, t);
            if (aviso == "")
            {
                if (login.AlteraCliForProc(c, e, m, t))
                {
                    aviso = "Alterado com sucesso!";
                }
                else
                {
                    aviso = "Não foi possivel alterar o cliente ou fonecedor";
                }
            }
            return aviso;
        }

        public List<string> Dados(string id)
        {
            CliForDao dados = new CliForDao();
            List<string> lista = dados.DadosCliFor(id);

            return lista;
        }
        private string VerificarCampos(CliFor i, Endereco e, Email m, Telefone t)
        {
            string msg = "";
            //email
            var rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (!rg.IsMatch(m.Mail))
                msg += " - E-mail não é valido! -\n";
            //bairro
            if (e.Bairro == "")
                msg += "- Preencha o Bairro! -\n";
            //cep
            rg = new Regex(@"\d{2}[.\s]?\d{3}[-.\s]?\d{3}");
            if (!rg.IsMatch(e.Cep))
                msg += " - CEP não é valido! -\n";
            //Logradouro
            if (e.Logradouro == "")
                msg += "- Preencha o Logradouro! -\n";
            //Municipio
            if (e.Cidade == "")
                msg += "- Preencha o Municipio! -\n";
            //CNPJ
            rg = new Regex(@"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)|(^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$)");
            if (!rg.IsMatch(i.Identificacao))
                msg += " - CNPJ não é valido! -\n";
            //Numero
            rg = new Regex(@"^\d+$");
            if (!rg.IsMatch(e.Numero))
                msg += " - Número não é valido! -\n";
            //Tel Fixo
            rg = new Regex(@"^(?:(?:\+|00)?(55)\s?)?(?:\(?([1-9][0-9])\)?\s?)?(?:((?:9\d|[2-9])\d{3})\-?(\d{4}))$");
            if (!rg.IsMatch(t.Fixo))
                msg += " - Telefone não é valido! -\n";
            //Tel Celular
            rg = new Regex(@"^(?:(?:\+|00)?(55)\s?)?(?:\(?([1-9][0-9])\)?\s?)?(?:((?:9\d|[2-9])\d{3})\-?(\d{4}))$");
            if (!rg.IsMatch(t.Celular))
                msg += " - Celular não é valido! -\n";
            //UF
            rg = new Regex(@"^[a-zA-Z]{2}$");
            if (!rg.IsMatch(e.Uf))
                msg += " - UF não é valida! -\n";
            //Fantasia
            if (i.Fantasia == "")
                msg += "- Preencha o Nome! -\n";
    
            return msg;
        }
    }
}
