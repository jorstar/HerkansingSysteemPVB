<%@ Page Title="Lokaal toevoegen" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="lokaalToevoegen.aspx.cs" Inherits="_Default" %>

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
                        <td>lokaal naam:</td>
                        <td>
                            <asp:TextBox placeholder="Lokaal naam" ID="txtLokaalNaam" CssClass="inputs" runat="server" Width="250px"> </asp:TextBox></td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Lokaal naam is een verplicht veld!" ControlToValidate="txtLokaalNaam" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td><br /></td>
                    </tr>
                    <tr>
                        <td>Aantal plaatsen:</td>
                        <td>
                            <asp:TextBox Text="1" ID="txtAantalPlaatsen" CssClass="inputs" min="1" max="20" runat="server" Width="250px" TextMode="number"></asp:TextBox></td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Vak beschrijving is een verplicht veld!" ControlToValidate="txtAantalPlaatsen" ForeColor="Red">*</asp:RequiredFieldValidator>
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
