<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AgriPro.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick">
        </asp:Timer>
        <br />
        <center>
            <asp:Image ID="Image3" runat="server" />
        </center>
        <br />
        <br />
        Contact&#39;s :<br />
        <br />
        &nbsp;<asp:Label ID="Label4" runat="server" Text="Commissionrate of Agriculture,M.S. <br/>Central Building 3'rd floor,<br/> Pune 411 001 <br/> Phone	(020) 26123648 / 26126150 <br/>Fax (020) 26127707 <br/> Email	comagri.pune@agri.maharashtra.gov.in"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Managining Director (NHM)<br/>Sakhar Sankul , Shivaji Nagar <br/>Pune 411 005 <br/>Phone		(020)25535441 <br />Fax		(020) 25511302	<br />Email		info@mahanhm.in "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Joint Director (Administration)	<br/>Commissionrate of Agriculture,M.S.<br/>Sakhar Sankul , Shivaji Nagar<br/>Pune 411 005 <br/>Phone		(020) 25512813 <br/>Fax		(020) 25512812"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
       
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
       

    </div>
    </form>
</body>
</html>
