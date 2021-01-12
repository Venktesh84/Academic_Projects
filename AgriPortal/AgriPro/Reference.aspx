<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reference.aspx.cs" Inherits="AgriPro.Reference" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

         <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/home.aspx">HomePage</asp:HyperLink>
         <br />
         <br />
        <br />

         <asp:Label ID="Label1" runat="server" Text="For Reference :"></asp:Label>
         <br />
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/1.PNG" Width="50%" />
&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="http://www.mahaagri.gov.in">Visit Page</asp:LinkButton>
         <br />
         <br />
        <br />
        <br />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/2.PNG" Width="50%" />
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="https://www.maharashtra.gov.in">Visit Page</asp:LinkButton>
         <br />
         <br />
         <br />
         <br />
        <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/3.PNG" Width="50%" />
        <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="http://farmer.gov.in/">Visit Page</asp:LinkButton>
        <br />
         <br />
         <br />
         <br />
        <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/4.PNG" Width="50%" />
        <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="http://mkisan.gov.in/">Visit Page</asp:LinkButton>
        
    
    </div>
    </form>
</body>
</html>
