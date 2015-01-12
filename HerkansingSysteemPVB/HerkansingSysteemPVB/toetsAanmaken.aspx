<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="toetsAanmaken.aspx.cs" Inherits="HerkansingSysteemPVB.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            height: 33px;
        }
    </style>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">

    <table style="text-align:center; width: 100%;">
        <tr>
            <td>

                <table style="width: 600px; margin: 50px auto 50px auto">
                    <tr>
                        <td>Toets titel:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Width="169px"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Vak:</td>
                        <td class="auto-style1">
                            <asp:DropDownList ID="DropDownList1" Width="169px" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style1"></td>
                    </tr>
                    <tr>
                        <td>Toets beschrijving:</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" Width="169px" Height="57px" TextMode="MultiLine"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;</td>
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
