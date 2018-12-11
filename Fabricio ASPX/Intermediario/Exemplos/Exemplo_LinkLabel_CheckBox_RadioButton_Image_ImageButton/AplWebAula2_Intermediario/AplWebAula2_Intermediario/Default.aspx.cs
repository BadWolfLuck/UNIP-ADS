using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplWebAula2_Intermediario
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSelecionarImagem_Click(object sender, ImageClickEventArgs e)
        {
            imgFoto.ImageUrl = "~/Imagens/imgbtnlimpar.png";
        }

        protected void rdoTamnahoPequeno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTamnahoPequeno.Checked)
            {
                imgAmpliada.ImageUrl = imgFoto.ImageUrl;
                imgAmpliada.Width = 150;
                imgAmpliada.Height = 75;
                imgAmpliada.Visible = true;
            }
        }

        protected void rdoTamanhoGrande_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTamanhoGrande.Checked)
            {
                imgAmpliada.ImageUrl = imgFoto.ImageUrl;
                imgAmpliada.Width = 750;
                imgAmpliada.Height = 325;
                imgAmpliada.Visible = true;
            }
        }

        protected void rdoTamanhoMedio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTamanhoMedio.Checked)
            {
                imgAmpliada.ImageUrl = imgFoto.ImageUrl;
                imgAmpliada.Width = 300;
                imgAmpliada.Height = 150;
                imgAmpliada.Visible = true;
            }
        }

        protected void rdoTamanhoExtraLargo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTamanhoExtraLargo.Checked)
            {
                imgAmpliada.ImageUrl = imgFoto.ImageUrl;
                imgAmpliada.Width = 1500;
                imgAmpliada.Height = 750;
                imgAmpliada.Visible = true;
            }
        }

        protected void btnLimparImagem_Click(object sender, ImageClickEventArgs e)
        {
            imgFoto.ImageUrl = "";
            imgAmpliada.ImageUrl = "";
            imgAmpliada.Visible = false;
        }
    }
}