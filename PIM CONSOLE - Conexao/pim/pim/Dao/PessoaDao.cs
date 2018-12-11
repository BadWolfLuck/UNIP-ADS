using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim.Models;
using MySql.Data.MySqlClient;

namespace pim.Dao
{
    class PessoaDao : ConexaoDao
    {
        MySqlCommand command = null;
        public void Incluir(Pessoa pessoa)
        {
            try
            {
                AbrirConexao();

                command = new MySqlCommand("INSERT INTO perepentech.PESSOA (NOME, ATIVO, FIDELIDADE, EMAIL) VALUES(@NOME, @ATIVO, @FIDELIDADE, @EMAIL)", connection);
                command.Parameters.AddWithValue("@NOME", pessoa.Nome);
                command.Parameters.AddWithValue("@ATIVO", pessoa.Ativo);
                command.Parameters.AddWithValue("@FIDELIDADE", pessoa.Fidelidade);
                command.Parameters.AddWithValue("@EMAIL", pessoa.Email);
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
