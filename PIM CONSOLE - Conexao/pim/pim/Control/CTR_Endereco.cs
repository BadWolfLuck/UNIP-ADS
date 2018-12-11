using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim.Models;
using pim.Dao;

namespace pim.Control
{
    class CTR_Endereco
    {
        EnderecoDao EnderecoDao = new EnderecoDao();

        public void Incluir(Endereco Endereco)
        {
            try
            {
                EnderecoDao.Incluir(Endereco);
            }

            catch (Exception erro)
            {
                throw erro;
            }

        }

        public void Consultar (Despesa Despesa)
        {

        }

        public void Alterar (Despesa Despesa)
        {

        }

        public void Excluir(Despesa Despesa)
        {

        }
    }
}
