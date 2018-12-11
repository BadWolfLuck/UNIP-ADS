using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim.Models;
using pim.Dao;

namespace pim.Control
{
    class CTR_PessoaFisica
    {
        PessoaFisicaDao PessoaFisicaDao = new PessoaFisicaDao();
        PessoaDao PessoaDao = new PessoaDao();
        EnderecoDao EnderecoDao = new EnderecoDao();
        public void Incluir(PessoaFisica PessoaFisica, Endereco endereco)
        {
            try
            {
                PessoaDao.Incluir(PessoaFisica);
                EnderecoDao.Incluir(endereco);
                PessoaFisicaDao.Incluir(PessoaFisica);
                
                
            }

            catch (Exception erro)
            {
                throw erro;
            }

        }

        /*public void Consultar(PessoaFisica PessoaFisica,Endereco endereco)
        {
            try
            {
                PessoaDao.Incluir(PessoaFisica);
                EnderecoDao.Incluir(endereco);
                PessoaFisicaDao.Incluir(PessoaFisica);


            }

            catch (Exception erro)
            {
                throw erro;
            }
        }*/

        public void Alterar(PessoaFisica PessoaFisica)
        {

        }

        public void Excluir(PessoaFisica PessoaFisica)
        {

        }
    }
}
