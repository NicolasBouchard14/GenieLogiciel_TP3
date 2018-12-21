<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SiteWebEnchere_NB.View.Home"  MasterPageFile="~/View/Layout.Master"%>

<asp:Content ID="HomeHeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="HomeMainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="ID" DataSourceID="ListeEnchereEnCours" GridLines="Horizontal">
        <Columns>
            <asp:BoundField DataField="NomEnchere" HeaderText="NomEnchere" SortExpression="NomEnchere" />
            <asp:BoundField DataField="PrixMinimum" HeaderText="PrixMinimum" SortExpression="PrixMinimum" />
            <asp:BoundField DataField="Duree" HeaderText="Duree" SortExpression="Duree" />
            <asp:BoundField DataField="TypeEnchere" HeaderText="TypeEnchere" SortExpression="TypeEnchere" />
            <asp:BoundField DataField="Categorie" HeaderText="Categorie" SortExpression="Categorie" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
        <asp:SqlDataSource ID="ListeEnchereEnCours" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnection %>" SelectCommand="SELECT * FROM [DemandeCreationEnchere]"></asp:SqlDataSource>
    </form>
</asp:Content>