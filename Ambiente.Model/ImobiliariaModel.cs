using Ambiente.Entidade;
using Ambiente.Control;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ambiente.Model
{
    public class ImobiliariaModel
    {
        private string aviso = "";

        public string salvar(Imobiliaria i, Endereco e, Email m, Telefone t)
        {
            ImobiliariaDao login = new ImobiliariaDao();

            string aviso = VerificarCampos(i,e,m,t);

            if (aviso == "")
            {
                if (login.salvarImobiliariaProc(i, e, m, t))
                {
                    aviso = "Cadastro com sucesso!";
                }
                else
                {
                    aviso = "Não foi possivel cadastrar a imobiliária";
                }
            }
            return aviso;
        }

        public string alterar(Imobiliaria i, Endereco e, Email m, Telefone t)
        {
            ImobiliariaDao login = new ImobiliariaDao();

            string aviso = VerificarCampos(i, e, m, t);

            if (aviso == "")
            {
                if (login.AlteraImobiliariaProc(i, e, m, t))
                {
                    aviso = "Alterado com sucesso!";
                }
                else
                {
                    aviso = "Não foi possivel alterar a imobiliária";
                }
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
            CliForDao dados = new CliForDao();
            List<string> lista = dados.DadosCliFor(id);

            return lista;
        }
        private string VerificarCampos(Imobiliaria i, Endereco e, Email m, Telefone t)
        {
            string msg = "";
            //plano
            if (i.Plano == "")
                msg += "- Selecione um plano! -\n";
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
            if (!rg.IsMatch(i.Cnpj))
                msg += " - CNPJ não é valido! -\n";
            /*//CPF
            rg = new Regex(@"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)|(^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$)");
            if (!rg.IsMatch(txtCPF.Text))
                msg += " - CPF não é valido! -\n";
                */
            //Numero
            rg = new Regex(@"^\d+$");
            if (!rg.IsMatch(e.Numero))
                msg += " - Número não é valido! -\n";
            //Creci
            if (i.Creci == "")
                msg += "- Preencha o Creci! -\n";
            //Tel Fixo
            rg = new Regex(@"^(?:(?:\+|00)?(55)\s?)?(?:\(?([1-9][0-9])\)?\s?)?(?:((?:9\d|[2-9])\d{3})\-?(\d{4}))$");
            if (!rg.IsMatch(t.Fixo))
                msg += " - Telefone não é valido! -\n";
            //Tel Celular
            rg = new Regex(@"^(?:(?:\+|00)?(55)\s?)?(?:\(?([1-9][0-9])\)?\s?)?(?:((?:9\d|[2-9])\d{3})\-?(\d{4}))$");
            if (!rg.IsMatch(t.Celular))
                msg += " - Telefone não é valido! -\n";
            //UF
            rg = new Regex(@"^[a-zA-Z]{2}$");
            if (!rg.IsMatch(e.Uf))
                msg += " - UF não é valida! -\n";
            //Fantasia
            if (i.Fantasia == "")
                msg += "- Preencha o Nome Fantasia! -\n";
            //IE
            if (i.Ie == "")
                msg += "- Preencha a Inscrição Estadual! -\n";
            //IM
            if (i.Im == "")
                msg += "- Preencha a Inscrição Municipal! -\n";
            //Razao
            if (i.Razao == "")
                msg += "- Preencha a Razão Social! -\n";
            return msg;
        }
    }
}

