<%@ Page Title="Mail bevestigen" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="MailBevestigen.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" Runat="Server">
    <table>
        <tr>
            <td colspan="2">
                Bevestig de aanmelding voor de volgende toets:
            </td>
        </tr>
        <tr>
            <td>vak:</td>
            <td>
                <asp:Label ID="lblvak" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>Toets:</td>
            <td><asp:Label ID="lbltoets" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>Beschrijving:</td>
            <td><asp:Label ID="lblbeschrijving" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>Datum:</td>
            <td><asp:Label ID="lbldatum" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>Tijdsduur:</td>
            <td><asp:Label ID="lbltijd" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>Lokaal:</td>
            <td><asp:Label ID="lbllokaal" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>Surveillant:</td>
            <td><asp:Label ID="lblsurveillant" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2">
                <hr />
                <br />
                <asp:Button ID="btnBevestigen" runat="server" Text="Bevestigen" OnClick="btnBevestigen_Click" />
            </td>
        </tr>
     </table>
</asp:Content>

