<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aflogin.aspx.cs" Inherits="AgriPro.aflogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
    </title>
    <link href="Styles/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <center><image>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Equipments.jpg" Height="250px" ImageAlign="Top" Width="90%" />
        </image></center>
            
        <ul>
            <li class="link"> <a href="home.aspx">Home</a></li>
            <li class="link"> <a href="Registration.aspx">Registration</a></li>
            <li class="link"> <a href="Contact.aspx">Contact</a></li>
            <li class="link"> <a href="Reference.aspx">References</a></li>
        </ul>

        <br />
        <br />
        <div> <center>
        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Enterprizes :"></asp:Label>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Seeds" />
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Fertilizers" />
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="Pesticides" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Show All" />
            <br />
            <br />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        <br />
                <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="dist" HeaderText="dist" SortExpression="dist" />
                <asp:BoundField DataField="entname" HeaderText="entname" SortExpression="entname" />
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AgriProjConnectionString %>" SelectCommand="SELECT * FROM [Seeds]"></asp:SqlDataSource>
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="dist" HeaderText="dist" SortExpression="dist" />
                    <asp:BoundField DataField="entname" HeaderText="entname" SortExpression="entname" />
                    <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                    <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
                </Columns>
            </asp:GridView>
        <br />
        <br />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:AgriProjConnectionString %>" SelectCommand="SELECT * FROM [Fertilizer]"></asp:SqlDataSource>
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3">
                <Columns>
                    <asp:BoundField DataField="dist" HeaderText="dist" SortExpression="dist" />
                    <asp:BoundField DataField="entname" HeaderText="entname" SortExpression="entname" />
                    <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                    <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:AgriProjConnectionString %>" SelectCommand="SELECT * FROM [Pesticide]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
    </center></div>
    </form>
</body>
</html>
