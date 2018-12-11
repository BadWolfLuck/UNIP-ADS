using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplWebAula3_Intermediario_3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calData_SelectionChanged(object sender, EventArgs e)
        {
            lblData.Text = calData.SelectedDate.ToString("dd/MM/yyyy");
            lblMes.Text = calData.SelectedDate.ToString("MMM");
            lblMes2.Text = calData.SelectedDate.ToString("MMMM");
        }
    }
}