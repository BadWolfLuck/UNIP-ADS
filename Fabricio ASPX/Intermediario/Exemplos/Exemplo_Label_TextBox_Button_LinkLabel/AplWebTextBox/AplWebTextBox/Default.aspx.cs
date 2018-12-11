using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplWebTextBox
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                lblMsgErro.Text = "Campo Nome vazio....";
            }
            else
            {
                Server.Transfer("frmWebResultado.aspx", true);
            }
        }
    }
}