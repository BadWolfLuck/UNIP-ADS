using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pim
{
    public class ConexaoDao
    {
        string conectar = "Server=perepentech.mysql.uhserver.com;Database=perepentech;Uid=perepentino;Pwd=pim@4!";
        protected  MySqlConnection connection=null;
        

        //Metodo para conectar no banco
        public void AbrirConexao()
        {
            try
            {
                connection = new MySqlConnection (conectar);
                connection.Open();
            }

            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                //connection.Close();
            }
        }

        //Metodo para fechar o banco
        public void FecharConexao()
        {
            try
            {
                connection = new MySqlConnection(conectar);
                connection.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
