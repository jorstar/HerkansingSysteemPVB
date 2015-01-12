<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="herkansingSurvianceMailen.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            height: 21px;
        }
    </style>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
    <table style="text-align: center; width: 100%;">
        <tr>
            <td>

                <table style="width: 900px; margin: 50px auto 50px auto">
                    <tr>
                        <td style="border-bottom: 2px solid black; padding: 10px 0">
                            De kandidaten</td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">



                            <asp:GridView ID="GridView1" runat="server" Width="900px" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" />
                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                            </asp:GridView>



                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td style="border-bottom: 2px solid black; padding: 10px 0">
                            De herkansing</td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>Toets titel:
                            <asp:Label ID="lblToetsNaam" runat="server" Text="oefen examen"></asp:Label><br />
                            Toets ID:
                            <asp:Label ID="lblToetsID" runat="server" Text="2356"></asp:Label><br />
                            Toets vak:
                            <asp:Label ID="Label1" runat="server" Text="Engels"></asp:Label><br />
                            Toets beschrijfing: 
                            <asp:Label ID="Label2" runat="server" Text="Dit is het oefen examen voor niveau 4"></asp:Label><br />
                            Herkansings Datum: 
                            <asp:Label ID="Label3" runat="server" Text="23 januari, 2015"></asp:Label>
                            <br />
                            Herkansing's lengte: 
                            <asp:Label ID="Label5" runat="server" Text="4 uur"></asp:Label>
                            <br />
                            Voor wie:
                            <asp:Label ID="Label6" runat="server" Text="Opleiding, Applicatie Ontwikkeling"></asp:Label>
                            <br />
                            Lokaal: 
                            <asp:Label ID="Label7" runat="server" Text="no.3.104"></asp:Label>
                            <br />
                            <br />
                            Surviance: 
                            <asp:Label ID="Label4" runat="server" Text="M. Roesink"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Button ID="Button1" runat="server" Text="Bevestig + mail " />

                        </td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>
</asp:Content>

