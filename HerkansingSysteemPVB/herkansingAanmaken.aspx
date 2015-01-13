<%@ Page Title="Herkansing aanmaken" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="herkansingAanmaken.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table style="text-align: center; width: 100%;">
                <tr style="width: 100%;">
                    <td>

                        <table style="width: 600px; margin: 50px auto 50px auto" class="fancyTable">
                            <tr>
                                <td>Toets:</td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <asp:DropDownList ID="ddlToetsen" Width="200px" runat="server" CssClass="inputs"></asp:DropDownList>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>Datum:</td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <div>
                                        <asp:TextBox ID="txtDatum" placeholder="Klik hier" runat="server" CssClass="inputs" Width="169px"></asp:TextBox>
                                        <asp:CalendarExtender ID="txtDatum_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtDatum">
                                        </asp:CalendarExtender>
                                    </div>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>Tijd:</td>
                                <td class="herkansingAanmakenRightTableCollumn" id="herkansingAanmakenSpecial">
                                    <asp:TextBox ID="txtUur" runat="server" Width="35px" TextMode="Number" max="23" min="0" CssClass="inputs"></asp:TextBox>
                                    :
                            <asp:TextBox ID="txtMinuten" runat="server" Width="35px" max="59" min="0" CssClass="inputs"></asp:TextBox>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>Lengte herkansing (minuten)
                                </td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <asp:TextBox ID="txtLengteHerkansing" placeholder="ex. 45" Width="169px" runat="server" min="15" max="480" TextMode="Number" CssClass="inputs"></asp:TextBox>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>
                                    <p>
                                        Surveillance:
                                    </p>
                                </td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <asp:DropDownList ID="ddlSureillance" Width="202px" runat="server" CssClass="inputs">
                                    </asp:DropDownList>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>Klas of opleiding:</td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <div style="width: 125px; margin: 0px auto 0px auto; text-align: left;">
                                        <asp:RadioButtonList ID="rblKlasOfOpleiding" runat="server" Width="125px" AutoPostBack="True">
                                            <asp:ListItem>Klas</asp:ListItem>
                                            <asp:ListItem>Opleiding</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>Selecteer klas/opleiding</td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <asp:DropDownList ID="ddlKlasOfOpleidingSelecteren" Width="200px" runat="server" CssClass="inputs">
                                    </asp:DropDownList>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>Aantal plaatsen (20 max)</td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <asp:TextBox ID="txtMaxPlaatsen" Width="169px" runat="server" Text="number" max="20" min="1" CssClass="inputs"></asp:TextBox>
                                </td>
                                <td></td>

                            </tr>
                            <tr>
                                <td>Lokaal selecteren</td>
                                <td class="herkansingAanmakenRightTableCollumn">
                                    <asp:DropDownList ID="ddlLokaal" Width="200px" runat="server" CssClass="inputs"></asp:DropDownList></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td></td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <asp:Button ID="btnBevestig" runat="server" Text="Bevestig" CssClass="fancyButton" /></td>
                            </tr>
                        </table>

                    </td>
                    <td>
                        <table style="width: 300px; margin: 50px auto 50px auto" class="fancyTable">
                            <tr>
                                <td style="font-size: 20px; border-bottom: 2px solid black;">Geselecteerde toets informatie</td>
                            </tr>
                            <tr>
                                <td>Toets titel:
                            <asp:Label ID="lblToetsNaam" runat="server" Text="oefen examen"></asp:Label><br />
                                    Toets ID:
                            <asp:Label ID="lblToetsID" runat="server" Text="2356"></asp:Label><br />
                                    Toets vak:
                            <asp:Label ID="Label1" runat="server" Text="Engels"></asp:Label><br />
                                    Toets beschrijfing: Toets ID:
                            <br />
                                    <asp:Label ID="Label2" runat="server" Text="Dit is het oefen examen voor niveau 4"></asp:Label><br />

                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
