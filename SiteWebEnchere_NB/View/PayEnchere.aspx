<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PayEnchere.aspx.cs" Inherits="SiteWebEnchere_NB.View.PayEnchere" MasterPageFile="~/View/Layout.Master" %>

<asp:Content ID="HomeHeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="HomeMainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header">
        <h1>Paiement</h1>
    </div>
        <div class="row">
            <div class="col-3">
                <asp:Label ID="Label_InformationsPaiement" runat="server" Text="Informations de paiement"></asp:Label>
            </div>
            <div class="col-4">
                <asp:TextBox ID="TextBox_InformationsPaiement" runat="server" CssClass="form-control" MaxLength="50" required/>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-3">
                <asp:Button ID="Payer_Enchere" runat="server" Text="Payer" OnClick="PayerEnchere" CssClass="btn btn-success" />
            </div>
        </div>
</asp:Content>
