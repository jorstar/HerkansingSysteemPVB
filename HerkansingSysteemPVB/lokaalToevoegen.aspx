<%@ Page Title="Lokaal toevoegen" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="lokaalToevoegen.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <table style="text-align: center; width: 100%;">
        <tr>
            <td>

                <table style="width: 600px; margin: 50px auto 50px auto" class="fancyTable">
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>lokaal naam<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Lokaal naam is een verplicht veld!" ControlToValidate="txtLokaalNaam" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox placeholder="Lokaal naam" ID="txtLokaalNaam" CssClass="inputs" runat="server" Width="250px"> </asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>Aantal plaatsen<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Aantal plaatsen is een verplicht veld!" ControlToValidate="txtAantalPlaatsen" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox Text="1" ID="txtAantalPlaatsen" CssClass="inputs" min="1" max="20" runat="server" Width="250px" TextMode="number"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnBevestig" CssClass="fancyButton" runat="server" Text="Bevestig" OnClick="btnBevestig_Click" /></td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 33%"></td>
                        <td style="width: 33%; text-align: left;">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF0202" />
                        </td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>
