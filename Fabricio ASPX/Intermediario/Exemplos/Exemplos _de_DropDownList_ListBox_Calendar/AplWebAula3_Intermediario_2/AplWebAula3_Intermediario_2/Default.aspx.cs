using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplWebAula3_Intermediario_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            lstNomes.Items.Add(txtTexto.Text);
            txtTexto.Text = "";
            txtTexto.Focus();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstNomes.SelectedIndex == -1)
            {
                lblMsgErro.Text = "Nenhum item foi selecionado!!!";
            }
            else
            {
                lstNomes.Items.RemoveAt(lstNomes.SelectedIndex);
                lblPosicaoLista.Text = "";
                lblTextoSelecionado.Text = "";
                lblTotalItens.Text = "";
            }
        }

        protected void btnLimparTodaLista_Click(object sender, EventArgs e)
        {
            lstNomes.Items.Clear();
            lblPosicaoLista.Text = "";
            lblTextoSelecionado.Text = "";
            lblTotalItens.Text = "";
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "";
            lstNomes.SelectedIndex =-1;
            lblPosicaoLista.Text = "";
            lblTextoSelecionado.Text = "";
            lblTotalItens.Text = "";
            txtTexto.Focus();
        }

        protected void lstNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPosicaoLista.Text = lstNomes.SelectedIndex.ToString();
            lblTextoSelecionado.Text = lstNomes.SelectedItem.ToString();
            lblTotalItens.Text = lstNomes.Items.Count.ToString();
        }
    }
}