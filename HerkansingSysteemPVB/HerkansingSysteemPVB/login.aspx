<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="HerkansingSysteemPVB.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            height: 22px;
        }
    </style>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">

    <table style="text-align:center; width: 100%;">
        <tr>
            <td>

                <table style="width: 500px; margin: 50px auto 50px auto">
                    <tr>
                        <td>Gebruikers Naam:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Width="146px"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Wachtwoord:
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox2" runat="server" Width="146px"></asp:TextBox>
                        </td>
                        <td class="auto-style1"></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Button" />
                        </td>
                        <td></td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>
