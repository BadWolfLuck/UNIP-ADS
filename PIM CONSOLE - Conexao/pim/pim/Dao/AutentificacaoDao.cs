using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pim.Models;
using MySql.Data.MySqlClient;

namespace pim.Dao
{
    class AutentificacaoDao : ConexaoDao
    {
        MySqlCommand command = null;

        public void Incluir(Autentificacao autentificacao)
        {
            try
            {
                AbrirConexao();
                command=new MySqlCommand("INSERT INTO perepentech.AUTENTIFICACAO (LOGIN, SENHA, ID_PESSOA) VALUES('@LOGIN', '@SENHA', @ID_PESSOA)",connection);
                command.Parameters.AddWithValue("@LOGIN", autentificacao.Login);
                command.Parameters.AddWithValue("@SENHA", autentificacao.Senha);

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
        public Boolean Logar (string Login,string Senha)
        {
            MySqlDataReader Leitor = null;
            try
            {
                AbrirConexao();
                command = new MySqlCommand("SELECT * FROM AUTENTIFICACAO WHERE LOGIN=@LOGIN AND SENHA=@SENHA", connection);
                command.Parameters.AddWithValue("@LOGIN", Login);
                command.Parameters.AddWithValue("@SENHA", Senha);
                Leitor = command.ExecuteReader();       
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();              
            }

            return Leitor.HasRows;
        }
    }
}
