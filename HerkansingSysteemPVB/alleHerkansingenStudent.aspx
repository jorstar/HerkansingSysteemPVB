<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="alleHerkansingenStudent.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
    <table style="text-align: center; width: 100%;">
        <tr>
            <td>

                <table style="width: 900px; margin: 50px auto 50px auto;">
                    <tr>
                        <td colspan="2">
                            <asp:GridView ID="GridView1" Width="900px" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>

                        <td rowspan="2">
                            <table style="height: 100%; width: 100%;">
                                <tr>
                                    <td>Selecteer een toets om voor aan te melden:
                                        <br />
                                        <asp:DropDownList ID="DropDownList2" Width="169px" runat="server"></asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div style="margin: 10px auto 10px auto; width: 297px;">
                                <asp:RadioButtonList Width="297px" ID="RadioButtonList1" runat="server">
                                    <asp:ListItem>Laat alle huidige herkansingen zien</asp:ListItem>
                                    <asp:ListItem>Laat alle beschikbare herkansingen zien</asp:ListItem>
                                    <asp:ListItem>Laat alle herkansingen zien die zijn geweest</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    
</asp:Content>
