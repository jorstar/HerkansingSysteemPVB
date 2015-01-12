<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="vakAanmaken.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 1191px;
        }
    </style>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
    <table style="text-align:center; width: 100%;">
        <tr>
            <td class="auto-style1">

                <table style="width: 600px; margin: 50px auto 50px auto" class="VakAanmakenTable">
                    <tr>
                        <td>Vak naam:</td>
                        <td>
                            <asp:TextBox placeholder="Vak naam" ID="txtVakNaam" CssClass="inputs" runat="server" Width="250px"> </asp:TextBox></td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Vak naam is een verplicht veld!" ControlToValidate="txtVakNaam" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td><br /></td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Button ID="Button1" CssClass="fancyButton" runat="server" Text="Bevestig" /></td>
                    </tr>
                    <tr>
                        <td><br /></td>
                    </tr>
                    <tr>
                        <td style="width:33%"></td>
                        <td style="width:33%">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                        </td>
                        <td style="width:33%"></td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>
