<%@ Page Title="Inloggen" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
    <div id="login">
        <table id="tablelogin" class="fancyTable" style="margin-top: 50px;">
            <tr>
                <td>Gebruikersnaam<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Gebruikersnaam is verplicht!" ControlToValidate="tbGebruikersnaam" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="herkansingAanmakenRightTableCollumn">
                    <asp:TextBox ID="tbGebruikersnaam" placeholder="Gebruikersnaam" runat="server" CssClass="inputs"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Wachtwoord<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Wachtwoord is verplicht!" Text="*" ControlToValidate="tbWachtwoord" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="herkansingAanmakenRightTableCollumn">
                    <asp:TextBox ID="tbWachtwoord" placeholder="Wachtwoord" runat="server" TextMode="Password" CssClass="inputs"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="fancyButton" OnClick="btnLogin_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <div style="width: 250px; text-align:left; margin: 5px auto">
                        <asp:ValidationSummary ID="ValidationSummary1" ForeColor="red" runat="server" />
                    </div>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
