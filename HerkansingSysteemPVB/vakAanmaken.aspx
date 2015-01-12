<%@ Page Title="Vak aanmaken" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="vakAanmaken.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
    <table style="text-align:center; width: 100%;">
        <tr>
            <td>

                <table style="width: 600px; margin: 50px auto 50px auto" class="fancyTable">
                    <tr><td><br /></td></tr>
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
                        <td>Vak beschrijving:</td>
                        <td>
                            <asp:TextBox placeholder="Vak beschrijving" ID="txtVakBeschrijving" CssClass="inputs" runat="server" Width="250px" Height="50px" TextMode="MultiLine"></asp:TextBox></td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Vak beschrijving is een verplicht veld!" ControlToValidate="txtVakBeschrijving" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td><br /></td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Button ID="btnBevestig" CssClass="fancyButton" runat="server" Text="Bevestig" OnClick="btnBevestig_Click" /></td>
                    </tr>
                    <tr>
                        <td> <br /></td>
                    </tr>
                    <tr>
                        <td style="width:33%"></td>
                        <td style="width:33%; text-align: left;">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                        </td>
                        <td style="width:33%"></td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>
