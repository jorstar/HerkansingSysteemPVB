﻿<%@ Page Title="Uitloggen" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="logoff.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">

    <table style="width: 100%; text-align:center;">
        <tr>
            <td>

                <table style="width: 300px;margin: 50px auto 50px auto;" class="fancyTable">
                    <tr>
                        <td>
                            <asp:Button ID="btnBevestig" runat="server" Text="Uitloggen Annuleren" CssClass="fancyButton" OnClick="btnBevestig_Click" /></td>
                        <td></td>
                        <td>
                            <asp:Button ID="btnAnnuleren" runat="server" Text="Uitloggen Bevestigen" CssClass="fancyButton" OnClick="btnAnnuleren_Click" /></td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>
