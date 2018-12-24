<%@ Page Title="" Language="C#" MasterPageFile="~/View/Layout.Master" AutoEventWireup="true" CodeBehind="ShowEnchere.aspx.cs" Inherits="SiteWebEnchere_NB.View.ShowEnchere" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header">
        <h1>Consulter une enchère</h1>
    </div>
    <div class="card">
        <div class="card-header">Informations de l'enchère</div>
        <div class="card-body">
            <div class="row">
                <div class="col-3">
                    <asp:Label ID="Label_NomEnchere" runat="server" Text="Nom"></asp:Label>
                </div>
                <div class="col-4">
                    <asp:TextBox ID="TextBox_NomEnchere" runat="server" CssClass="form-control" MaxLength="50" required Enabled="false" />
                </div>
            </div>
            <div class="row">
                <div class="col-3">
                    <asp:Label ID="Label_PrixMin" runat="server" Text="Prix minimum"></asp:Label>
                </div>
                <div class="col-4">
                    <asp:TextBox ID="TextBox_PrixMin" runat="server" CssClass="form-control" required Enabled="false" />
                </div>
            </div>

            <div class="row">
                <div class="col-3">
                    <asp:Label ID="Label_Duree" runat="server" Text="Durée"></asp:Label>
                    &nbsp;(en heure)
                </div>
                <div class="col-4">
                    <asp:TextBox ID="TextBox_Duree" runat="server" CssClass="form-control" TextMode="Number" required Enabled="false" />
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
                    <asp:DropDownList ID="DropDownList_OptionTransport" runat="server" CssClass="form-control" Width="135px" Enabled="false">
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
                    <asp:Label ID="Label_AutresInfos" runat="server" Text="Autres informations"></asp:Label>
                </div>
                <div class="col-9">
                    <asp:TextBox ID="TextBox_AutresInfos" runat="server" TextMode="MultiLine" Columns="50" Rows="5" CssClass="form-control" Enabled="false"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <asp:Panel ID="Panel_Action" runat="server" Visible="false">
        <div class="card">
            <div class="card-body">
                <div class="row">
                    <div class="col-12">
                        <asp:TextBox ID="TextBox_OffreMaximale" runat="server" CssClass="form-control" TextMode="Number" />
                        <asp:Button ID="Button_Encherir" runat="server" Text="Enchérir" OnClick="SubmitEncherissement" CssClass="btn btn-success" />
                        <asp:CheckBox ID="CheckBox_Follow" runat="server" Text="Suivre" OnCheckedChanged="FollowEnchere" />
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
    <br />
</asp:Content>
