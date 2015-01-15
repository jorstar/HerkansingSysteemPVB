<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="aanmeldenHerkansing.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">

    <table style="text-align: center; width: 100%;">
        <tr>
            <td>

                <table style="width: 600px; margin: 50px auto 50px auto">
                    <tr>
                        <td>
                            <asp:GridView ID="dgvKandidaten" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                            <hr />
                            </td>
                        </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddlHerkansingen" runat="server"></asp:DropDownList>
                             <asp:Button ID="btnAanmelden" runat="server" Text="Aanmelden" OnClick="btnAanmelden_Click" />
                        </td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>
