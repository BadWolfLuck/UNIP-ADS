using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using pim.Models;

namespace pim.Dao
{
    class FuncionarioDao: ConexaoDao
    {
        MySqlCommand command = null;
        public void Incluir(Funcionario funcionario)
        {
            try
            {
                AbrirConexao();
                command = new MySqlCommand("INSERT INTO perepentech.FUNCIONARIO (NOME, RG, CPF, CARGO, SALARIO, ID_PESSOA) VALUES(@NOME, @RG, @CPF, @CARGO, @SALARIO, @ID_PESSOA)",connection);
                command.Parameters.AddWithValue("@NOME", funcionario.Nome);
                command.Parameters.AddWithValue("@RG", funcionario.RG);
                command.Parameters.AddWithValue("@CPF", funcionario.CPF);
                command.Parameters.AddWithValue("@CARGO", funcionario.Cargo);
                command.Parameters.AddWithValue("@SALARIO", funcionario.Salario);

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
        }
    }
}
