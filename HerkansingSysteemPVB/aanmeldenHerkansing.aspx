<%@ Page Title="Aanmelden voor Herkansing" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="aanmeldenHerkansing.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">

    <table style="text-align: center; width: 100%;">
        <tr>
            <td>

                <table class="fancyTable" style="width: 400px; margin: 50px auto 0 auto">
                    <tr>
                        <td>Vak:</td>
                        <td><asp:Label ID="lblvak" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Toets:</td>
                        <td><asp:Label ID="lblToets" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Beschrijving:</td>
                        <td><asp:Label ID="lblBeschrijving" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Datum:</td>
                        <td><asp:Label ID="lblDatum" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Tijdsduur:</td>
                        <td><asp:Label ID="lblTijdsduur" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Lokaal:</td>
                        <td><asp:Label ID="lblLokaal" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Aantal Plaatsen:</td>
                        <td><asp:Label ID="lblPlaatsen" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Surveillant:</td>
                        <td><asp:Label ID="lblSurveillant" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <hr />
                            <asp:Button ID="btnAanmelden" CssClass="fancyButton" runat="server" Text="Aanmelden" OnClick="btnAanmelden_Click" />
                        </td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>
