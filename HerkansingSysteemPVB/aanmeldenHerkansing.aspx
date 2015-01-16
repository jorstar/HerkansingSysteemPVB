<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="aanmeldenHerkansing.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">

    <table style="text-align: center; width: 100%;">
        <tr>
            <td>

                <table style="width: 600px; margin: 50px auto 50px auto">
                    <tr>
                        <td>Vak:</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>Beschrijving:</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>Vak:</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnAanmelden" runat="server" Text="Aanmelden" OnClick="btnAanmelden_Click" />
                        </td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>
