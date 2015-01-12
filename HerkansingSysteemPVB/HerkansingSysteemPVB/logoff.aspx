<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="logoff.aspx.cs" Inherits="HerkansingSysteemPVB.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">

    <table style="width: 100%; text-align:center;">
        <tr>
            <td>

                <table style="width: 300px;margin: 50px auto 50px auto;">
                    <tr>
                        <td>
                            <asp:Button ID="btnBevestig" runat="server" Text="Uitloggen Annuleren" /></td>
                        <td></td>
                        <td>
                            <asp:Button ID="btnAnnuleren" runat="server" Text="Uitloggen Bevestigen" /></td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>
