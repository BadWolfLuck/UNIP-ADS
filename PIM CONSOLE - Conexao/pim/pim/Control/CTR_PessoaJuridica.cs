using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim.Models;
using pim.Dao;

namespace pim.Control
{
    class CTR_PessoaJuridica
    {
        PessoaJuridicaDao PessoaJuridicaDao = new PessoaJuridicaDao();

        public void Incluir(PessoaJuridica PessoaJuridica)
        {
            try
            {
                PessoaJuridicaDao.Incluir(PessoaJuridica);
            }

            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Consultar(PessoaJuridica PessoaJuridica)
        {

        }

        public void Alterar(PessoaJuridica PessoaJuridica)
        {

        }

        public void Excluir(PessoaJuridica PessoaJuridica)
        {

        }
    }
}
