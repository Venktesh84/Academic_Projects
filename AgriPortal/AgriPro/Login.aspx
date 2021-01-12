<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="none" CodeBehind="Login.aspx.cs" Inherits="AgriPro.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color:lavender;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        </div>
       <center> 
           <asp:Label ID="Label1" runat="server" Font-Names="Cambria" Font-Size="Larger" ForeColor="#3366CC" Text="Login Page"></asp:Label>
           <br />
           <br />
           <br />
           <br />
           <br />
           <asp:Label ID="Label2" runat="server" Text="UserName :" BackColor="#CCCCCC"></asp:Label>
&nbsp;
           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
           <br />
           <br />
           <asp:Label ID="Label3" runat="server" Text="PassWord :" BackColor="#CCCCCC"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
           <br />
           <br />
           <asp:Button ID="Button1" runat="server" Text="Login" BackColor="#3366FF" BorderColor="#000066" BorderStyle="Double" Font-Names="Lucida Handwriting" OnClick="Button1_Click1" />
           <br />
           <br />
           <br />
           <br />
           <asp:Literal ID="Literal1" runat="server"></asp:Literal>
           </center>
    </form>
</body>
</html>
