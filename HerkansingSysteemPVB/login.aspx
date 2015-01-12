<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
<div id="login">
    <table id="tablelogin">
        <tr>
            <td>
                Gebruikersnaam:
            </td>
            <td>
                <asp:TextBox ID="tbGebruikersnaam" placeholder="Gebruikersnaam" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Wachtwoord:
            </td>
            <td>
                <asp:TextBox ID="tbWachtwoord" placeholder="Wachtwoord" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" />
            </td>
        </tr>
    </table>
</div>
</asp:Content>