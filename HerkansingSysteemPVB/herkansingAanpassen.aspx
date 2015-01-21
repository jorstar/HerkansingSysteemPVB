<%@ Page Title="Toets aanpassen" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="herkansingAanpassen.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table style="text-align: center; width: 100%;">
                <tr>
                    <td>

                        <table style="width: 600px; margin: 50px auto 50px auto" class="fancyTable">
                            <tr>
                                <td style="border-bottom: 2px solid black; padding: 10px 0px 10px 0px;">Selecteer herkansing</td>
                                <td style="border-bottom: 2px solid black;" class="herkansingAanmakenRightTableCollumn">
                                    <asp:DropDownList ID="ddlHerkansingen" Width="200px" runat="server" CssClass="inputs" AutoPostBack="True" OnSelectedIndexChanged="ddlHerkansingen_SelectedIndexChanged"></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>Toets:</td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <asp:DropDownList ID="ddlToetsen" Width="200px" runat="server" CssClass="inputs" AutoPostBack="True" OnSelectedIndexChanged="ddlToetsen_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>Datum:</td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <div>
                                        <asp:TextBox ID="txtDatum" placeholder="Klik hier" runat="server" CssClass="inputs" Width="169px">txtDatum</asp:TextBox>
                                        <asp:CalendarExtender ID="CalendarExtender1" runat="server" TodaysDateFormat="dd/MM/YYYY" Format="dd/MM/YYYY" TargetControlID="txtDatum"></asp:CalendarExtender>
                                    </div>

                                </td>
                            </tr>
                            <tr>
                                <td>Tijd:</td>
                                <td class="herkansingAanmakenRightTableCollumn" id="herkansingAanmakenSpecial">
                                    <asp:TextBox ID="txtUur" runat="server" Width="35px" TextMode="Number" max="23" min="0" CssClass="inputs"></asp:TextBox>
                                    :
                            <asp:TextBox ID="txtMinuten" runat="server" Width="35px" TextMode="Number" max="59" min="0" CssClass="inputs"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Lengte herkansing (minuten)<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLengteHerkansing" ErrorMessage="Herkansing lengte is een verplicht veld" ForeColor="Red">*</asp:RequiredFieldValidator>
                                </td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <asp:TextBox ID="txtLengteHerkansing" placeholder="ex. 45" Width="169px" runat="server" min="15" max="480" TextMode="Number" CssClass="inputs"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p>
                                        Surveillance:
                                    </p>
                                </td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <asp:DropDownList ID="ddlSureillance" Width="202px" runat="server" CssClass="inputs" AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>Klas of opleiding:</td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <div style="width: 125px; margin: 0px auto 0px auto; text-align: left;">
                                        <asp:RadioButtonList ID="rblKlasOfOpleiding" runat="server" Width="125px" AutoPostBack="True" OnSelectedIndexChanged="rblKlasOfOpleiding_SelectedIndexChanged">
                                            <asp:ListItem>Klas</asp:ListItem>
                                            <asp:ListItem>Opleiding</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>Selecteer klas/opleiding</td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <asp:DropDownList ID="ddlKlasOfOpleidingSelecteren" Width="200px" runat="server" CssClass="inputs" AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>Aantal plaatsen<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtMaxPlaatsen" ErrorMessage="Aantal plaatsen is een verplicht veld" ForeColor="Red">*</asp:RequiredFieldValidator>
                                </td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <asp:TextBox ID="txtMaxPlaatsen" placeholder="Min:1 / Max: 20" Width="169px" runat="server" TextMode="number" max="20" min="1" CssClass="inputs"></asp:TextBox>
                                </td>

                            </tr>
                            <tr>
                                <td>Lokaal selecteren</td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <asp:DropDownList ID="ddlLokaal" Width="200px" runat="server" CssClass="inputs" AutoPostBack="True"></asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>Herkansing actief</td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <asp:CheckBox ID="cbActief" runat="server" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <asp:Button ID="btnBevestig" runat="server" Text="Bevestig" CssClass="fancyButton" OnClick="btnBevestig_Click" /></td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <div style="margin: 15px auto 15px auto; width: 350px;">

                                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF0202" />

                                    </div>
                                </td>
                            </tr>
                        </table>

                    </td>
                    <td>
                        <table style="width: 300px; margin: 50px auto 50px auto; text-align: left;" class="fancyTable">
                            <tr style="text-align: center;">
                                <td style="font-size: 20px; border-bottom: 2px solid black;">Geselecteerde toets informatie</td>
                            </tr>
                            <tr>
                                <td>Toets titel:
                            <asp:Label ID="lblToetsNaam" runat="server" Text="Geen toets naam"></asp:Label><br />
                                    Toets ID:
                            <asp:Label ID="lblToetsID" runat="server" Text="Geen toets ID"></asp:Label><br />
                                    Toets vak:
                            <asp:Label ID="lblToetsVak" runat="server" Text="Geen teoets vak"></asp:Label><br />
                                    Toets beschrijfing:
                            <br />
                                    <asp:Label ID="lblToetsBeschrijving" runat="server" Text="Geen toets beschrijving beschikbaar"></asp:Label><br />

                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>


