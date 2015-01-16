<%@ Page Title="Wachtwoord wijzigen" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="wachtwoordWijzigen.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">

    <table style="text-align: center; width: 100%;">
        <tr>
            <td>

                <table class="fancyTable" style="width: 600px; margin: 50px auto 50px auto;">
                    <tr>
                        <td style="width: 50%;">Het oude wachtwoord

                        </td>
                        <td class="herkansingAanmakenRightTableCollumn">

                            <asp:TextBox ID="txtOldPass" CssClass="inputs" Width="169px" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>Het nieuwe wachtwoord

                        </td>
                        <td class="herkansingAanmakenRightTableCollumn">

                            <asp:TextBox ID="txtNewPass" CssClass="inputs" runat="server" Width="169px"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>Het nieuwe wachtwoord (check)

                        </td>
                        <td class="herkansingAanmakenRightTableCollumn">

                            <asp:TextBox ID="txtNewPassCheck" CssClass="inputs" runat="server" Width="169px"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                     <tr>
                        <td colspan="2">
                            <asp:Button ID="btnBevestig" CssClass="fancyButton" runat="server" Text="Bevestig" />
                        </td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>