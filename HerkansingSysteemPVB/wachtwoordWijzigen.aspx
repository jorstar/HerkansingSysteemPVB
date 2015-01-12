<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="wachtwoordWijzigen.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">

    <table style="text-align: center; width: 100%;">
        <tr>
            <td>

                <table style="width: 600px; margin: 50px auto 50px auto;">
                    <tr>
                        <td style="width: 50%;">Het oude wachtwoord

                        </td>
                        <td>

                            <asp:TextBox ID="TextBox1" Width="169px" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>Het nieuwe wachtwoord

                        </td>
                        <td>

                            <asp:TextBox ID="TextBox2" runat="server" Width="169px"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>Het nieuwe wachtwoord (check)

                        </td>
                        <td>

                            <asp:TextBox ID="TextBox3" runat="server" Width="169px"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                     <tr>
                        <td colspan="2">
                            <asp:Button ID="Button1" runat="server" Text="Bevestig" />
                        </td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>