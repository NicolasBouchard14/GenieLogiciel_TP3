<%@ Page Title="" Language="C#" MasterPageFile="~/View/Layout.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="SiteWebEnchere_NB.View.AddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header">
        <h1>Créer un compte</h1>
    </div>
        <!-- Informations de compte -->
        <div class="card">
            <div class="card-header">Informations de compte</div>
            <div class="card-body">
                <div class="form-group">
                    <div class="row">
                        <div class="col-3">
                            <asp:Label ID="Label_NomUtilisateur" runat="server" Text="Nom d'utilisateur"></asp:Label>
                        </div>
                        <div class="col-4">
                            <asp:TextBox ID="TextBox_NomUtilisateur" runat="server" CssClass="form-control" MaxLength="25" required />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-3">
                            <asp:Label ID="Label_MDP" runat="server" Text="Mot de passe"></asp:Label>
                        </div>
                        <div class="col-4">
                            <asp:TextBox ID="TextBox_MDP" runat="server" TextMode="Password" CssClass="form-control" MaxLength="100" required />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-3">
                            <asp:Label ID="Label_MDP2" runat="server" Text="Confirmation mot de passe"></asp:Label>
                        </div>
                        <div class="col-4">
                            <asp:TextBox ID="TextBox_MDP2" runat="server" TextMode="Password" CssClass="form-control" MaxLength="100" required />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-3">
                            <asp:Label ID="Label_Courriel" runat="server" Text="Courriel"></asp:Label>
                        </div>
                        <div class="col-4">
                            <asp:TextBox ID="TextBox_Courriel" runat="server" TextMode="Email" CssClass="form-control" MaxLength="50" required />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-3">
                            <asp:Label ID="Label_Courriel2" runat="server" Text="Confirmation courriel"></asp:Label>
                        </div>
                        <div class="col-4">
                            <asp:TextBox ID="TextBox_Courriel2" runat="server" TextMode="Email" CssClass="form-control" MaxLength="50" required />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-3">
                            <asp:Label ID="Label_Langue" runat="server" Text="Langue par défaut"></asp:Label>
                        </div>
                        <div class="col-9">
                            <asp:DropDownList ID="DropDownList_Langue" runat="server" CssClass="form-control" Width="135px">
                                <asp:ListItem Selected="True">Français</asp:ListItem>
                                <asp:ListItem>Anglais</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Renseignements personnels -->
        <div class="card">
            <div class="card-header">Renseignements personnels</div>
            <div class="card-body">
                <div class="form-group">
                    <div class="row">
                        <div class="col-3">
                            <asp:Label ID="Label_Prenom" runat="server" Text="Prenom"></asp:Label>
                        </div>
                        <div class="col-4">
                            <asp:TextBox ID="TextBox_Prenom" runat="server" CssClass="form-control" MaxLength="50" required />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-3">
                            <asp:Label ID="Label_Nom" runat="server" Text="Nom"></asp:Label>
                        </div>
                        <div class="col-4">
                            <asp:TextBox ID="TextBox_Nom" runat="server" CssClass="form-control" MaxLength="50" required />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-3">
                            <asp:Label ID="Label_Adresse" runat="server" Text="Adresse"></asp:Label>
                        </div>
                        <div class="col-4">
                            <asp:TextBox ID="TextBox_Adresse" runat="server" CssClass="form-control" MaxLength="100" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-3">
                            <asp:Label ID="Label_Tel" runat="server" Text="Téléphone"></asp:Label>
                        </div>
                        <div class="col-4">
                            <asp:TextBox ID="TextBox_tel" runat="server" CssClass="form-control" TextMode="Phone" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-3">
                            <asp:Label ID="Label_DateNaissance" runat="server" Text="Date de naissance"></asp:Label>
                        </div>
                        <div class="col-4">
                            <asp:TextBox ID="TextBox_DateNaissance" runat="server" CssClass="form-control" TextMode="Date" required/>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <br />
        <div class="row">
            <div class="col-3">
                <asp:Button ID="Submit_NewUser" runat="server" Text="Soumettre" OnClick="SubmitNewUser" CssClass="btn btn-success" />
            </div>
        </div>
</asp:Content>
