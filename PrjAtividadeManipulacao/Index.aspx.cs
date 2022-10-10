using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjAtividadeManipulacao
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtLogar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Luan" && txtSenha.Text == "admin123")
            {
                HttpCookie cookie = new HttpCookie("nome");  
                cookie.Value = txtLogin.Text;

                HttpCookie cookie2 = new HttpCookie("senha");
                cookie2.Value = txtSenha.Text;


                DateTime agora = DateTime.Now; 
                TimeSpan tempo = new TimeSpan(0, 20, 0); 
                cookie.Expires = agora + tempo;
                cookie2.Expires = agora + tempo;

                Response.Cookies.Add(cookie);
                Response.Cookies.Add(cookie);
                Response.Redirect("imc.aspx");


            }
            else
            {  
                lblMensagem.CssClass = "avisoErro";
                lblMensagem.Text = "Usuario ou senha invalidos";
            }
        }

        protected void btnlimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
            lblMensagem.Text = "";
        }
    }
}