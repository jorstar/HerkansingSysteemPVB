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

                <table class="fancyTable">
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
                        <td >
                            <asp:GridView ID="dgvKandidaten" runat="server" Width="900px" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                        <td>
                            <table class="align tablewhiteround">
                                <tr>
                                    <td>Toets Titel:</td>
                                    <td>
                                        <asp:Label ID="lblToetsTitel" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>Toets ID:</td>
                                    <td>
                                        <asp:Label ID="lblToetsID" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>Vak:</td>
                                    <td>
                                        <asp:Label ID="lblVak" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>Toets Beschrijving:</td>
                                    <td>
                                        <asp:Label ID="lblBeschrijving" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>Herkansings Datum:</td>
                                    <td>
                                        <asp:Label ID="lblDatumTijd" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>Herkansings Lengte:</td>
                                    <td>
                                        <asp:Label ID="lblLengte" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>Studenten Van:</td>
                                    <td>
                                        <asp:Label ID="lblStudvan" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>Lokaal:</td>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td>Surveillant:</td>
                                    <td>
                                        <asp:Label ID="lblSurveillant" runat="server" Text=""></asp:Label></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Button ID="btnMail" runat="server" Text="Mailen naar Surveillant" />

                        </td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>
</asp:Content>

