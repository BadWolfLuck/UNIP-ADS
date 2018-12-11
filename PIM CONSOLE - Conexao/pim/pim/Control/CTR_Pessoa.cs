using pim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim.Dao;

namespace pim.Control
{
    class CTR_Pessoa
    {
        PessoaDao PessoaDao = new PessoaDao();
        public void Incluir (Pessoa pessoa)
        {
            try
            {
                
                PessoaDao.Incluir(pessoa);
            }

            catch (Exception erro)
            {
                throw erro;
            }


        }

        public void Consultar(Pessoa pessoa)
        {
        }

        public void Alterar(Pessoa pessoa)
        {

        }

        public void Excluir(Pessoa pessoa)
        {

        }
    }
}
