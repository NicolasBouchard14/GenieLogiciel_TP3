<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEnchere.aspx.cs" Inherits="SiteWebEnchere_NB.View.AddEnchere" MasterPageFile="~/View/Layout.Master" %>

<asp:Content ID="HomeHeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="HomeMainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header">
        <h1>Ajouter une enchère</h1>
    </div>
    <form id="Form_Enchere" runat="server" class="form-group">
        <div class="row">
            <div class="col-3">
                <asp:Label ID="Label_NomEnchere" runat="server" Text="Nom"></asp:Label>
            </div>
            <div class="col-4">
                <asp:TextBox ID="TextBox_NomEnchere" runat="server" CssClass="form-control" required />
            </div>
        </div>
        <div class="row">
            <div class="col-3">
                <asp:Label ID="Label_PrixMin" runat="server" Text="Prix minimum"></asp:Label>
            </div>
            <div class="col-4">
                <asp:TextBox ID="TextBox_PrixMin" runat="server" TextMode="Number" CssClass="form-control" required/>
            </div>
        </div>

        <div class="row">
            <div class="col-3">
                <asp:Label ID="Label_Duree" runat="server" Text="Durée"></asp:Label>
                &nbsp;(en heure)
            </div>
            <div class="col-4">
                <asp:TextBox ID="TextBox_Duree" runat="server" CssClass="form-control" TextMode="Number" required />
            </div>
        </div>
        <div class="row">
            <div class="col-3">
                <asp:Label ID="Label2" runat="server" Text="Catégorie"></asp:Label>
            </div>
            <div class="col-9">
                <asp:DropDownList ID="DropDownList_Categorie" runat="server" CssClass="form-control" Width="135px" Enabled="false">
                    <asp:ListItem Selected="True">Standard</asp:ListItem>
                </asp:DropDownList>

            </div>
        </div>
        <div class="row">
            <div class="col-3">
                <asp:Label ID="Label3" runat="server" Text="Transport"></asp:Label>
            </div>
            <div class="col-9">
                <asp:DropDownList ID="DropDownList_OptionTransport" runat="server" CssClass="form-control" Width="121px">
                    <asp:ListItem Selected="True">Standard</asp:ListItem>
                    <asp:ListItem>Rapide</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-3">
                <asp:Button ID="Submit_Enchere" runat="server" Text="Soumettre" OnClick="SubmitEnchere" CssClass="btn btn-success" />
            </div>
        </div>
    </form>
</asp:Content>
