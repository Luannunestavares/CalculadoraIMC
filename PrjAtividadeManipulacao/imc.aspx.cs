using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrjAtividadeManipulacao.Classes;


namespace PrjAtividadeManipulacao
{
    public partial class imc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string login, senha;
            try
            {
                HttpCookie cookie = Request.Cookies["nome"];
                HttpCookie cookie2 = Request.Cookies["senha"];
                login = cookie.Value.ToString();
                senha = cookie.Value.ToString();

                


                lblNomeCookie.Text = "Nome do usuário: " + login;
            }
            catch (NullReferenceException)
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {
            string resultado1, resultado2;

            try
            {
                txtPeso.Text = txtPeso.Text.Replace(".", ",");
                txtAltura.Text = txtAltura.Text.Replace(".", ",");




                if (Convert.ToDouble(txtPeso.Text) >= 210 || Convert.ToDouble(txtAltura.Text) >= 2.25)
                {

                    lblErro.Text = "Erro! Por favor,Insira uma altura menor que 2.25 e um peso menor que 210";
                    lblPeso.CssClass = "avisoErro";
                    lblAltura.CssClass = "AvisoErro";
                }

                else if (Convert.ToDouble(txtPeso.Text) <= 5 || Convert.ToDouble(txtAltura.Text) <= 0.10)
                {
                    lblErro.Text = "Erro! Por favor, Insira uma altura maior que 0.10cm e o peso maior que 5 kg";
                    lblPeso.CssClass = "avisoErro";
                    lblAltura.CssClass = "avisoErro";
                }

                else
                {
                    resultado1 = operacoes.Calcular(txtPeso.Text, txtAltura.Text);
                    resultado2 = operacoes.AvisoIMC(Convert.ToDouble(resultado1));
                    //lblresultado.Text = resultado2;
                    Session["nome"] = lblNomeCookie.Text;
                    Session["Resposta"] = resultado2;
                    Session["Calculo"] = resultado1;
                    Response.Redirect("resultado.aspx");

                }
                
                
            }

            catch(FormatException)
            {
               
                lblErro.Text = "Por favor, certifique-se de preencher os campos solicitados";
            }
            


            
        }
            protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtPeso.Text = "";
            lblresultado.Text = "";
            lblErro.Text = "";
            lblPeso.CssClass = "clean";
            lblAltura.CssClass = "clean";
        }

        protected void btnOff_Click(object sender, EventArgs e)
        {
            Response.Cookies["nome"].Expires = DateTime.Now.AddDays(-1); 
            Response.Cookies["senha"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("index.aspx");
        }
    }
}