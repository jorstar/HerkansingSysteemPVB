<%@ Page Title="Toets aanmaken" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="toetsAanmaken.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <table style="text-align: center; width: 100%;">
        <tr>
            <td>

                <table style="width: 600px; margin: 50px auto 50px auto" class="fancyTable">
                    <tr class="ToetsAanmakenSpacing">
                        <td>Toets titel<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtToetsTitel" ErrorMessage="Toets titel is verplicht." ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="txtToetsTitel" placeholder="Toets titel" runat="server" Width="220px" CssClass="inputs"></asp:TextBox></td>
                    </tr>
                    <tr class="ToetsAanmakenSpacing">
                        <td class="auto-style1">Vak</td>
                        <td class="auto-style1">
                            <asp:DropDownList ID="ddlVakken" Width="250px" runat="server" CssClass="inputs" AutoPostBack="True">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr class="ToetsAanmakenSpacing">
                        <td>Toets beschrijving<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtToetsBeschrijving" ErrorMessage="Toets beschrijving is verplicht." ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="txtToetsBeschrijving" placeholder="Toets beschrijving" runat="server" Width="220px" Height="57px" TextMode="MultiLine" CssClass="inputs"></asp:TextBox></td>
                    </tr>
                    <tr class="ToetsAanmakenSpacing">
                        <td colspan="2">
                            <asp:Button ID="btnBevestigen" runat="server" Text="Bevestig" CssClass="fancyButton" OnClick="btnBevestigen_Click" /></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td style="text-align: left;">

                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />

                        </td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>
