<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEnchere.aspx.cs" Inherits="SiteWebEnchere_NB.View.AddEnchere" MasterPageFile="~/View/Layout.Master" %>

<asp:Content ID="HomeHeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="HomeMainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header">
        <h1>Ajouter une enchère</h1>
    </div>
        <div class="row">
            <div class="col-3">
                <asp:Label ID="Label_NomEnchere" runat="server" Text="Nom"></asp:Label>
            </div>
            <div class="col-4">
                <asp:TextBox ID="TextBox_NomEnchere" runat="server" CssClass="form-control" MaxLength="50" required />
            </div>
        </div>
        <div class="row">
            <div class="col-3">
                <asp:Label ID="Label_PrixMin" runat="server" Text="Prix minimum"></asp:Label>
            </div>
            <div class="col-4">
                <asp:TextBox ID="TextBox_PrixMin" runat="server" TextMode="Number" CssClass="form-control" required />
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
                <asp:Label ID="Label_Categorie" runat="server" Text="Catégorie"></asp:Label>
            </div>
            <div class="col-9">
                <asp:DropDownList ID="DropDownList_Categorie" runat="server" CssClass="form-control" Width="135px" Enabled="false">
                    <asp:ListItem Selected="True">Standard</asp:ListItem>
                </asp:DropDownList>

            </div>
        </div>
        <div class="row">
            <div class="col-3">
                <asp:Label ID="Label_Transport" runat="server" Text="Transport"></asp:Label>
            </div>
            <div class="col-9">
                <asp:DropDownList ID="DropDownList_OptionTransport" runat="server" CssClass="form-control" Width="135px">
                    <asp:ListItem Selected="True">Standard</asp:ListItem>
                    <asp:ListItem>Rapide</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="col-3">
                <asp:Label ID="Label_TypeEnchere" runat="server" Text="Type"></asp:Label>
            </div>
            <div class="col-9">
                <asp:DropDownList ID="DropDownList_TypeEnchere" runat="server" CssClass="form-control" Width="135px" Enabled="false">
                    <asp:ListItem Selected="True">Chronométrée</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
         <div class="row">
            <div class="col-3">
                <asp:Label ID="Label_MotsCles" runat="server" Text="Mots clés" MaxLength="100"></asp:Label>
            </div>
            <div class="col-4">
                <asp:TextBox ID="TextBox_MotsCles" runat="server" CssClass="form-control" />
            </div>
        </div>
        <div class="row">
            <div class="col-3">
                <asp:Label ID="Label_AutresInfos" runat="server" Text="Autres informations"></asp:Label>
            </div>
            <div class="col-9">
                <asp:TextBox ID="TextBox_AutresInfos" runat="server" TextMode="MultiLine" Columns="50" Rows="5" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-3">
                <asp:Button ID="Submit_Enchere" runat="server" Text="Soumettre" OnClick="SubmitEnchere" CssClass="btn btn-success" />
            </div>
        </div>
</asp:Content>
