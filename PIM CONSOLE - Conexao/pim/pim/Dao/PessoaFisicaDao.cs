using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim.Models;
using pim.Dao;
using MySql.Data.MySqlClient;

namespace pim.Dao
{
    class PessoaFisicaDao : ConexaoDao
    {
        MySqlCommand command = null;
        public void Incluir(PessoaFisica pessoaFisica)
        {
            try
            {
                AbrirConexao();
                command = new MySqlCommand("INSERT INTO perepentech.FISICO (CPF, RG, ID_PESSOA) VALUES(@CPF, @RG, @ID_PESSOA)");
                command.Parameters.AddWithValue("@CPF", pessoaFisica.CPF);
                command.Parameters.AddWithValue("@RG", pessoaFisica.RG);


                command.ExecuteNonQuery();


            }

            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
            
            PessoaFisica consulta (PessoaFisica pesoaFisica)
            {
                if (pesoaFisica == null)
                {
                    throw new ArgumentNullException(nameof(pesoaFisica));
                    return pessoaFisica = null;
                }

                try
                {
                    AbrirConexao();
                    command = new MySqlCommand("SELECT * FROM perepentech.FISICO WHERE CPF= " +pesoaFisica.CPF , connection);
                    return pesoaFisica;
                }
                catch(Exception erro)
                {
                    return pesoaFisica = null;
                }
            }

            
        }
    }
}
