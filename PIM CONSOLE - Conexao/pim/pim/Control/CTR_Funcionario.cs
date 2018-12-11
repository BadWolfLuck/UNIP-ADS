using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim.Models;
using pim.Dao;

namespace pim.Control
{
    class CTR_Funcionario
    {
        FuncionarioDao FuncionarioDao = new FuncionarioDao();
        public void Incluir(Funcionario Funcionario)
        {
            try
            {
                FuncionarioDao.Incluir(Funcionario);
            }

            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Consultar(Funcionario Funcionario)
        {

        }

        public void Alterar(Funcionario Funcionario)
        {

        }

        public void Excluir(Funcionario Funcionario)
        {

        }
    }
}
