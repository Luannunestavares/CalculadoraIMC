<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resultado.aspx.cs" Inherits="PrjAtividadeManipulacao.resultado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body
        {
            background-color:cornflowerblue;
            width: 350px;
            margin: 165px auto;
            padding: 0 20px 20px 20px;
            border: 10px double white;
            line-height:2;
           
        }

         #container{
            text-align:center;
          
        }

          h1{
            color:black;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            font-size:30px;
            text-align:center;
            display:block;
            line-height: 2;
            letter-spacing: 2px;
            padding:initial;
        }
    </style>
</head>
<body>
    <form id="resultado" runat="server">

        <div class="container">

            <h1> Resultado</h1>

            
            
            <asp:Label ID="lblNome" runat="server" Text= "" ></asp:Label>
            <br />
            <asp:Label ID="lblResultado" runat="server" Text="Resultado: "></asp:Label>
            <asp:Label ID="lblResultadoResposta" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblCalc" runat="server" Text="Calculo: "></asp:Label>
            <asp:Label ID="lblCalcResposta" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnOff" runat="server" Text="Desconectar" OnClick="btnOff_Click" style="height: 26px" />


        </div>
    </form>
</body>
</html>
