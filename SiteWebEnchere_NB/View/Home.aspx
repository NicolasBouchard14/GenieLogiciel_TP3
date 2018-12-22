<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SiteWebEnchere_NB.View.Home" MasterPageFile="~/View/Layout.Master" %>

<asp:Content ID="HomeHeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="HomeMainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header">
        <h1>Accueil - Liste des enchères en cours</h1>
    </div>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataSourceID="EnchereMapperSource" GridLines="Horizontal" AllowPaging="True" AllowSorting="True" Width="1235px" AutoGenerateColumns="False">
            <Columns>
                <asp:HyperLinkField AccessibleHeaderText="Nom" DataTextField="NomEnchere" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="~/SiteWebEnchere_NB?command=ShowEnchere" />
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
    </form>
</asp:Content>
