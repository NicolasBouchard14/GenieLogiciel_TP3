<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Authenticate.aspx.cs" Inherits="SiteWebEnchere_NB.View.Authenticate" MasterPageFile="~/View/Layout.Master" %>

<asp:Content ID="AuthenticateHeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="AuthenticateMainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Form_Login" runat="server">
    <div>
        <asp:Login ID="Login" runat="server" OnAuthenticate="ValidateUser"></asp:Login>
    </div>
    </form>
</asp:Content>

