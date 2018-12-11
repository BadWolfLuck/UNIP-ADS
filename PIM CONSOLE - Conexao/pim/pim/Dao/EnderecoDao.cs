using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using pim.Models;


namespace pim.Dao
{
    class EnderecoDao : ConexaoDao
    {
        MySqlCommand command = null;
        public void Incluir(Endereco endereco)
        {
            try
            {
                AbrirConexao();
                command = new MySqlCommand("INSERT INTO perepentech.ENDERECO(CEP, RUA, BAIRRO, NUMERO, TELEFONE) VALUES(@CEP, @RUA, @BAIRRO, @NUMERO, @TELEFONE)", connection);
                command.Parameters.AddWithValue("@CEP", endereco.CEP);
                command.Parameters.AddWithValue("@RUA", endereco.Rua);
                command.Parameters.AddWithValue("@BAIRRO", endereco.Bairro);
                command.Parameters.AddWithValue("@NUMERO", endereco.Numero);
                command.Parameters.AddWithValue("@TELEFONE", endereco.Telefone);

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
