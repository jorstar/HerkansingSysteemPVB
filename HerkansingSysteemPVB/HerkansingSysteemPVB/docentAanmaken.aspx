<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="docentAanmaken.aspx.cs" Inherits="HerkansingSysteemPVB.WebForm10" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">

    <table style="text-align:center; width: 100%;">
        <tr>
            <td>

                <table style="width: 600px; margin: 50px auto 50px auto">
                    <tr>
                        <td>Voornaam:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Width="169px"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>Tussenvoegsel:</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" Width="169px"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>Achternaam:</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" Width="169px"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>E-mail:</td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" Width="169px"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Button ID="Button1" runat="server" Text="Bevestig" /></td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>
