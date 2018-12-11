using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplWebAula3_Intermerdiario
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            ddlNomes.Items.Add(txtTexto.Text);
            txtTexto.Text = "";
            txtTexto.Focus();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ddlNomes.SelectedIndex == -1)
            {
                lblMsgErro.Text = "Nenhum item foi selecionado!!!";
            }
            else
            {
                ddlNomes.Items.RemoveAt(ddlNomes.SelectedIndex);
                lblPosicaoLista.Text = "";
                lblTextoSelecionado.Text = "";
                lblTotalItens.Text = "";
            }
        }

        protected void btnLimparTodaLista_Click(object sender, EventArgs e)
        {
            ddlNomes.Items.Clear();
            ddlNomes.Items.Add("Selecionar um Nome");
            lblPosicaoLista.Text = "";
            lblTextoSelecionado.Text = "";
            lblTotalItens.Text = "";
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "";
            ddlNomes.SelectedIndex = 0;
            lblPosicaoLista.Text = "";
            lblTextoSelecionado.Text = "";
            lblTotalItens.Text = "";
            txtTexto.Focus();
        }

        protected void ddlNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPosicaoLista.Text = ddlNomes.SelectedIndex.ToString();
            lblTextoSelecionado.Text = ddlNomes.SelectedItem.ToString();
            lblTotalItens.Text = ddlNomes.Items.Count.ToString();
        }
    }
}