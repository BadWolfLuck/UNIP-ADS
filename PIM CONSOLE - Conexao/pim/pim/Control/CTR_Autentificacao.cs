using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim.Models;
using pim.Dao;

namespace pim.Control
{
    class CTR_Autentificacao
    {
        AutentificacaoDao AutentificacaoDao = new AutentificacaoDao();

        public void Incluir(Autentificacao autentificacao)
        {
            try
            {
                AutentificacaoDao.Incluir(autentificacao);
            }

            catch (Exception erro)
            {
                throw erro;
            }

        }

        public void Consultar(Autentificacao autentificacao)
        {

        }

        public void Alterar(Autentificacao autentificacao)
        {

        }

        public void Excluir(Autentificacao autentificacao)
        {

        }
    }
}
