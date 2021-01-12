<%@ Page Language="C#" UnobtrusiveValidationMode="none" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="AgriPro.Resgistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Registration_css.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        
            <asp:Label ID="Label1" runat="server" Font-Names="Cambria" Font-Size="X-Large" ForeColor="#990000" Text="Sign Up for New Account" BackColor="#CCCCCC" Font-Bold="True"></asp:Label>
            <br />
            <br />
            
            <div >
            <asp:Label ID="Label2" runat="server" Text="First Name :"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Last Name :"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Age :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Age is Required!" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Education :"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Address :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="*Address is Mandatory.!" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="District :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>&lt;Select District&gt;</asp:ListItem>
                <asp:ListItem>Ahmednagar</asp:ListItem>
                <asp:ListItem>Akola</asp:ListItem>
                <asp:ListItem>Amravati</asp:ListItem>
                <asp:ListItem>Aurangabad</asp:ListItem>
                <asp:ListItem>Beed</asp:ListItem>
                <asp:ListItem>Bhandara</asp:ListItem>
                <asp:ListItem>Buldhana</asp:ListItem>
                <asp:ListItem>Chandrapur</asp:ListItem>
                <asp:ListItem>Dhule</asp:ListItem>
                <asp:ListItem>Gadchiroli</asp:ListItem>
                <asp:ListItem>Gondia</asp:ListItem>
                <asp:ListItem>Hingoli</asp:ListItem>
                <asp:ListItem>Jalgaon</asp:ListItem>
                <asp:ListItem>Jalna</asp:ListItem>
                <asp:ListItem>Kolhapur</asp:ListItem>
                <asp:ListItem>Latur</asp:ListItem>
                <asp:ListItem>Mumbai City</asp:ListItem>
                <asp:ListItem>Mumbai Suburban</asp:ListItem>
                <asp:ListItem>Nagpur</asp:ListItem>
                <asp:ListItem>Nanded</asp:ListItem>
                <asp:ListItem>Nandurbar</asp:ListItem>
                <asp:ListItem>Nashik</asp:ListItem>
                <asp:ListItem>Osmanabad</asp:ListItem>
                <asp:ListItem>Parbhani</asp:ListItem>
                <asp:ListItem>Pune</asp:ListItem>
                <asp:ListItem>Raigad</asp:ListItem>
                <asp:ListItem>Ratnagiri</asp:ListItem>
                <asp:ListItem>Sangli</asp:ListItem>
                <asp:ListItem>Satara</asp:ListItem>
                <asp:ListItem>Sindhudurg</asp:ListItem>
                <asp:ListItem>Solapur</asp:ListItem>
                <asp:ListItem>Thane</asp:ListItem>
                <asp:ListItem>Wardha</asp:ListItem>
                <asp:ListItem>Washim</asp:ListItem>
                <asp:ListItem>Yavatmal</asp:ListItem>
                <asp:ListItem>Palghar</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*Select District" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" Font-Names="Cambria" Font-Size="Large" ForeColor="#990000" Text="Login Credentials Details"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label9" runat="server" Text="UserName :"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox7" ErrorMessage="*Field Can't be Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="Label10" runat="server" Text="PassWord :"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox8" runat="server" TextMode="Password" Width="164px"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox9" ControlToValidate="TextBox8" ErrorMessage="PassWord Not Matched!" ForeColor="Red"></asp:CompareValidator>
        </p>
        <p>
            <asp:Label ID="Label11" runat="server" Text="Re-Enter :"></asp:Label>
&nbsp;&nbsp; <asp:TextBox ID="TextBox9" runat="server" TextMode="Password" Width="162px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="SignUp" OnClick="Button1_Click" BorderColor="#0066CC" Font-Italic="True" Font-Names="Calisto MT" Font-Size="Medium" Font-Strikeout="False" />
        </p>
                <p>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </p>
                <p>
                    &nbsp;</p>
                <p>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/home.aspx">HomePage</asp:HyperLink>
        </p>
        </div>
    </form>
    </body>
</html>
