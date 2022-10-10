<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="imc.aspx.cs" Inherits="PrjAtividadeManipulacao.imc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .avisoErro{
            color:red;
        }

      body
        {
            background-color:cornflowerblue;
            width: 350px;
            margin: 165px auto;
            padding: 0 20px 20px 20px;
            border: 10px double white;
            line-height:2;
        }
 
        #Calculo{
            display:flex;
            justify-content:center;
            
        }

          h1{
            color:black;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            font-size:30px;
            text-align:center;
            display:block;
            line-height: 1;
            letter-spacing: 2px;
            padding:initial;
        }
        
    </style>
</head>
<body>
    <form id="Calculo" runat="server">
        <div>
              <h1> Calculo IMC SenaFit</h1>

            <asp:Label ID="lblNomeCookie" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID ="lblPeso" runat="server" text ="Peso"></asp:Label>
            <asp:TextBox ID ="txtPeso" runat="server"  placeholder ="digite o seu Peso "></asp:TextBox> 
            <br />
            <asp:Label ID="lblAltura" runat="server" text="Altura"></asp:Label>
            <asp:TextBox ID ="txtAltura" runat="server"  placeholder =" digite a sua altura"></asp:TextBox> 
            <br />
            <asp:Button ID ="btnCalc" runat="server" Text="Calcular" OnClick="btnCalc_Click"></asp:Button> <br />
            <asp:Label ID ="lblresultado" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
            <asp:Button ID="btnOff" runat="server" Text="Desconectar" OnClick="btnOff_Click" />
            <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
        
        </div>
    </form>
</body>
</html>
