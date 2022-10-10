<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PrjAtividadeManipulacao.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SenaFit</title>
    <link href ="/css/reset.css" rel="stylesheet" />
     <style> 
    
     .clean{
         color:black;
     }
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

 
        #login{
            display:flex;
            justify-content:center;
            
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
    <form id="login" runat="server">

        
        <div class="container">
             
            <h1> Login SenaFit</h1>
            
            <asp:Label ID="lblNome" runat="server" Text="nome"></asp:Label>
            <asp:TextBox ID="txtLogin" runat="server" placeHolder="Login"></asp:TextBox>
            <br />
            <asp:Label ID="lblSenha" runat="server" Text="senha"></asp:Label>
            <asp:TextBox ID="txtSenha" runat="server" placeHolder="Senha" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="txtLogar" runat="server" text="logar" OnClick="txtLogar_Click" />
            <asp:Button ID="btnlimpar" runat="server" Text="limpar" OnClick="btnlimpar_Click"/>
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>

        
        </div>
    </form>
</body>
</html>
