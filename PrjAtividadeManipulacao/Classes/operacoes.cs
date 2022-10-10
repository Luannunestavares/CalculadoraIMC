using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PrjAtividadeManipulacao.Classes
{
    public static class operacoes
    {
        public static string Calcular(string valor1,string valor2)
        {

            

             return (Convert.ToDouble(valor1) / (Convert.ToDouble (valor2) * 2)).ToString();
            
            
            //double peso = Convert.ToDouble(v1);
            //double altura= Convert.ToDouble(v2);
            //double imcResul = peso / (altura * 2);
            //return AvisoIMC(imcResul);
            //double r1 = Convert.ToDouble(v1), r2 = Convert.ToDouble(v2);
            //r1 = (r1 / (r2 * 2));
           // return AvisoIMC(r1);

        }
        public static string AvisoIMC(double valor3)
        {
            if (valor3 < 20.8)
            {
                return "Abaixo do Peso!!!";
            }
            else if (valor3 > 20.6 && valor3 < 26.5)
            {
                return "Peso ideal.";
            }
            else if (valor3> 26.4 && valor3  < 27.9)
            {
                return "Pouco acima do Peso.";
            }
            else if (valor3 > 27.8 && valor3 <= 31.2)
            {
                return "Acima do Peso!!!";
            }
            else
            {
                return "Obesidade!!!";
            }
        }

    }
    
}