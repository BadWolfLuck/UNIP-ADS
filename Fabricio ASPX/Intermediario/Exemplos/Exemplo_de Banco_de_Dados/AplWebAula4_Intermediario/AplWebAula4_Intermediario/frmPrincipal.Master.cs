using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace AplWebAula4_Intermediario
{
    public partial class frmPrincipal : System.Web.UI.MasterPage
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                pblCnx.ConnectionString = "Server=localhost;Database=bdcapacitacao;user=root;password=master";
                pblCnx.Open();
            }
            catch (Exception Erro)
            {
                lblMensagem.Text = Erro.Message.ToString();
            }
        }

        protected void btnLimpar_Click(object sender, ImageClickEventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtFone.Text = "";
            lblMensagem.Text = "";
            txtCodigo.Focus();
        }

        protected void btnConsultar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                string strSql;

                strSql = "Select * From tblagenda Where agdid = " + txtCodigo.Text;

                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblDados = pblCmd.ExecuteReader();
                if (pblDados.HasRows)
                {
                    pblDados.Read();
                    txtCodigo.Text = pblDados["agdid"].ToString();
                    txtNome.Text = pblDados["agdnome"].ToString();
                    txtFone.Text = pblDados["agdtelefone"].ToString();
                }
                else
                {
                    lblMensagem.Text = "Código inexistente !!!";
                    txtCodigo.Focus();
                }
            }
            catch (Exception Erro)
            {
                lblMensagem.Text = Erro.Message.ToString();
            }
            finally
            {
                if (!pblDados.IsClosed) { pblDados.Close(); }
            }
        }

        protected void btnCadastrar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                string strSql;

                strSql = "Select * From tblagenda Where agdid = " + txtCodigo.Text;

                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblDados = pblCmd.ExecuteReader();
                if (!pblDados.HasRows)
                {
                    if (!pblDados.IsClosed) { pblDados.Close(); }

                    strSql = "Insert into tblagenda (agdid,agdnome,agdtelefone) values (";
                    strSql += txtCodigo.Text + ",";
                    strSql += "'" + txtNome.Text + "',";
                    strSql += "'" + txtFone.Text + "')";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    lblMensagem.Text = "Registro incluído com sucesso !!!";

                    if (!pblDados.IsClosed) { pblDados.Close(); }
                }
                else
                {
                    lblMensagem.Text = "Código Existente !!!";
                    txtCodigo.Focus();
                }
            }
            catch (Exception Erro)
            {
                lblMensagem.Text = Erro.Message.ToString();
            }
            finally
            {
                if (!pblDados.IsClosed) { pblDados.Close(); }
            }
        }

        protected void btnAlterar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                string strSql;

                strSql = "Select * From tblagenda Where agdid = " + txtCodigo.Text;

                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblDados = pblCmd.ExecuteReader();
                if (pblDados.HasRows)
                {
                    if (!pblDados.IsClosed) { pblDados.Close(); }

                    strSql = "Update tblagenda set ";
                    strSql += "agdnome = '" + txtNome.Text + "',";
                    strSql += "agdtelefone = '" + txtFone.Text + "' ";
                    strSql += "Where agdid = " + txtCodigo.Text;
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    lblMensagem.Text = "Registro alterado com sucesso !!!";
                }
                else
                {
                    lblMensagem.Text = "Código Inexistente !!!";
                    txtCodigo.Focus();
                }
            }
            catch (Exception Erro)
            {
                lblMensagem.Text = Erro.Message.ToString();
            }
            finally
            {
                if (!pblDados.IsClosed) { pblDados.Close(); }
            }
        }

        protected void btnExcluir_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                string strSql;

                strSql = "Select * From tblagenda Where agdid = " + txtCodigo.Text;

                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblDados = pblCmd.ExecuteReader();
                if (pblDados.HasRows)
                {
                    if (!pblDados.IsClosed) { pblDados.Close(); }
                    strSql = "Delete From tblagenda Where agdid = " + txtCodigo.Text;
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    lblMensagem.Text = "Registro excluído com sucesso !!!";
                }
                else
                {
                    lblMensagem.Text = "Código Inexistente !!!";
                    txtCodigo.Focus();
                }
            }
            catch (Exception Erro)
            {
                lblMensagem.Text = Erro.Message.ToString();
            }
        }
    }
}