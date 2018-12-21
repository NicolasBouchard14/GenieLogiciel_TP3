<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEnchere.aspx.cs" Inherits="SiteWebEnchere_NB.View.AddEnchere" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="Form_Enchere" runat="server">
    <div>
        <asp:Label ID="Label_NomEnchere" runat="server" Text="Nom"></asp:Label>
        <asp:TextBox ID="TextBox_NomEnchere" runat="server" style="margin-left: 139px"></asp:TextBox>

    </div>
        <p>

        <asp:Label ID="Label_Duree" runat="server" Text="Durée"></asp:Label>
        &nbsp;(en heure)<asp:TextBox ID="TextBox_Duree" runat="server" style="margin-left: 68px; margin-bottom: 0px"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="Label2" runat="server" Text="Catégorie"></asp:Label>
        <asp:DropDownList ID="DropDownList_Categorie" runat="server" style="margin-left: 111px" Width="120px"></asp:DropDownList>
        </p>
        <p>
        <asp:Label ID="Label3" runat="server" Text="Transport"></asp:Label>
        <asp:DropDownList ID="DropDownList_OptionTransport" runat="server" Height="16px" style="margin-left: 111px" Width="120px"></asp:DropDownList>

        </p>
        <p>

        <asp:Button ID="Submit_Enchere" runat="server" Text="Soumettre" OnClick="SubmitEnchere"/>
        </p>
    </form>
</body>
</html>
