<%@ Page Title="Mail bevestigen" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="MailBevestigen.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="Server">
    <div style="width: 100%;">
        <table class="fancyTable"  style="margin: 50px auto 0 auto; width: 350px;">
            <tr>
                <td class="herkansingAanmakenRightTableCollumn" colspan="2">Bevestig de aanmelding voor de volgende toets:
                </td>
            </tr>
            <tr>
                <td>vak:</td>
                <td class="herkansingAanmakenRightTableCollumn">
                    <asp:Label ID="lblvak" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>Toets:</td>
                <td class="herkansingAanmakenRightTableCollumn">
                    <asp:Label ID="lbltoets" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>Beschrijving:</td>
                <td class="herkansingAanmakenRightTableCollumn">
                    <asp:Label ID="lblbeschrijving" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>Datum:</td>
                <td class="herkansingAanmakenRightTableCollumn">
                    <asp:Label ID="lbldatum" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>Tijdsduur:</td>
                <td class="herkansingAanmakenRightTableCollumn">
                    <asp:Label ID="lbltijd" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>Lokaal:</td>
                <td class="herkansingAanmakenRightTableCollumn">
                    <asp:Label ID="lbllokaal" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>Surveillant:</td>
                <td class="herkansingAanmakenRightTableCollumn">
                    <asp:Label ID="lblsurveillant" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="text-align:center; padding: 10px 0;" colspan="2">
                    <asp:Button CssClass="fancyButton" ID="btnBevestigen" runat="server" Text="Bevestigen" OnClick="btnBevestigen_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

