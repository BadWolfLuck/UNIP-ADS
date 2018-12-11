using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim.Models;
using MySql.Data.MySqlClient;

namespace pim.Dao
{
    class PessoaJuridicaDao: ConexaoDao
    {
        MySqlCommand command = null;
        public void Incluir (PessoaJuridica pessoaJuridica)
        {
            try
            {
                AbrirConexao();
                command = new MySqlCommand("INSERT INTO perepentech.JURIDICO (CNPJ, IE, ID_PESSOA) VALUES(@CNPJ, @IE, @ID_PESSOA)",connection);
                command.Parameters.AddWithValue("@CNPJ", pessoaJuridica.CNPJ);
                command.Parameters.AddWithValue("@IE", pessoaJuridica.IE);

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
