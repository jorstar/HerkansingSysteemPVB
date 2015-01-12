<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="herkansingAanmaken.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 50px;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">

    <table style="text-align: center; width: 100%;">
        <tr>
            <td>

                <table style="width: 600px; margin: 50px auto 50px auto" class="fancyTable">
                    <tr>
                        <td>Toets:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList2" Width="169px" runat="server" CssClass="inputs"></asp:DropDownList>
                            <td></td>
                    </tr>
                    <tr>
                        <td>Datum:</td>
                        <td>
                            <div style="width: 220px; margin: 0px auto 0px auto">
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                            </div>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>Tijd:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Width="35px" MaxLength="2" TextMode="Number" CssClass="inputs"></asp:TextBox>
                            :
                            <asp:TextBox ID="TextBox2" runat="server" Width="35px" MaxLength="2" CssClass="inputs"></asp:TextBox>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>Lengte herkansing
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox3" Width="169px" runat="server" TextMode="Number" CssClass="inputs"></asp:TextBox>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <p>
                                Surveillance:
                            </p>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList3" Width="169px" runat="server" CssClass="inputs">
                            </asp:DropDownList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Klas of opleiding:</td>
                        <td class="auto-style1">
                            <div style="width: 125px; margin: 0px auto 0px auto">
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="125px">
                                    <asp:ListItem>Klas</asp:ListItem>
                                    <asp:ListItem>Opleiding</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                        </td>
                        <td class="auto-style1"></td>
                    </tr>
                    <tr>
                        <td>Selecteer klas/opleiding</td>
                        <td>
                            <asp:DropDownList ID="DropDownList4" Width="169px" runat="server" CssClass="inputs">
                            </asp:DropDownList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>Aantal plaatsen (20 max)</td>
                        <td>
                            <asp:TextBox ID="TextBox4" Width="169px" runat="server" CssClass="inputs"></asp:TextBox>
                        </td>
                        <td></td>

                    </tr>
                    <tr>
                        <td>Lokaal selecteren</td>
                        <td>
                            <asp:DropDownList ID="DropDownList5" Width="169px" runat="server" CssClass="inputs"></asp:DropDownList></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Button ID="Button1" runat="server" Text="Bevestig" CssClass="fancyButton" /></td>
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

</asp:Content>