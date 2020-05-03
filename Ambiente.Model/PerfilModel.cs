using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambiente.Entidade;
using Ambiente.Control;

namespace Ambiente.Model
{
    public class PerfilModel
    {
        public string salvar(Perfil p)
        {
            PerfilDao per = new PerfilDao();

            string aviso = null;
            if (per.SalvaPerfil(p.Nome,p.Permissoes))
            {
                aviso = "Cadastro com sucesso!";
            }
            else
            {
                aviso = "Não foi possivel cadastrar o perfil";
            }
            return aviso;
        }
        public string Deletar(Perfil p)
        {
            PerfilDao per = new PerfilDao();

            string aviso = null;
            if (per.DeletarPerfil(p.Id))
            {
                aviso = "Deletado com sucesso!";
            }
            else
            {
                aviso = "Não foi possivel deletar o perfil";
            }
            return aviso;
        }
    }
}
