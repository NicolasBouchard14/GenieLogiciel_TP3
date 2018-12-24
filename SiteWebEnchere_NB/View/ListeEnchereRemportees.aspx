<%@ Page Title="" Language="C#" MasterPageFile="~/View/Layout.Master" AutoEventWireup="true" CodeBehind="ListeEnchereRemportees.aspx.cs" Inherits="SiteWebEnchere_NB.View.ListeEnchereRemportees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header">
        <h1>Accueil - Liste des enchères remportées</h1>
    </div>
        <asp:GridView ID="GridView" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataSourceID="EnchereMapperSource" GridLines="Horizontal" AllowPaging="True" AllowSorting="True" Width="1235px" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="NomEnchere" />
                <asp:HyperLinkField AccessibleHeaderText="Nom" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="~/SiteWebEnchere_NB?command=PayEnchere&amp;ID={0}" Text="Payer" />
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
        <asp:ObjectDataSource ID="EnchereMapperSource" runat="server" SelectMethod="FindAll" TypeName="SiteWebEnchere_NB.DAL.MSSQL.EnchereMapper"></asp:ObjectDataSource>
</asp:Content>
