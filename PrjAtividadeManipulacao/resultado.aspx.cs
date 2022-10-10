using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjAtividadeManipulacao
{
    public partial class resultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lblNome.Text = (string)Session["Nome"];
                lblResultadoResposta.Text = (string)Session["Resposta"];
                lblCalcResposta.Text = (string)Session["Calculo"];
                


            }
            catch (NullReferenceException)
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void btnOff_Click(object sender, EventArgs e)
        {
            Response.Cookies["nome"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["senha"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("index.aspx");
        }
    }
}