<%@ Page Title="Overzicht herkansingen" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="alleHerkansingenDocent.aspx.cs" EnableEventValidation="false" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
    <table style="text-align: center; width: 100%;">
        <tr>
            <td>
                <table class="fancyTable" style="width: 900px; margin: 50px auto 50px auto;">
                    <tr>
                        <td colspan="2">
                            <asp:GridView CssClass="BlackTextGrid" ID="dgvDocentenHerkansingOverzicht" Width="900px" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowCustomPaging="false" AllowPaging="true" PageSize="15" OnPageIndexChanging="dgvDocentenHerkansingOverzicht_PageIndexChanging" OnRowDataBound="dgvDocentenHerkansingOverzicht_RowDataBound" OnSelectedIndexChanged="dgvDocentenHerkansingOverzicht_SelectedIndexChanged">
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
                            <asp:GridView CssClass="BlackTextGrid" ID="dgvDocentenOverzichtAlternatief" Width="900px" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowCustomPaging="false" AllowPaging="true" PageSize="15" OnPageIndexChanging="dgvDocentenOverzichtAlternatief_PageIndexChanging">
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
                                    <td>Selecteer een toets om alle kandidaten te zien:
                                        <br />
                                        <asp:DropDownList CssClass="inputs" ID="ddlSelecteerdHerkansing" Width="169px" runat="server" OnSelectedIndexChanged="ddlSelecteerdHerkansing_SelectedIndexChanged"></asp:DropDownList>
                                        <br />
                                        <asp:Button CssClass="fancyButton" ID="btnTonen" Text="Tonen" runat="server" OnClick="btnTonen_Click" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div style="margin: 10px auto 10px auto; width: 350px;">
                                <asp:RadioButtonList Width="350px" ID="rdbVeranderDisplay" AutoPostBack="true" runat="server">
                                    <asp:ListItem Value="Laat beschikbare herkansingen zien" Selected="True">Laat beschikbare herkansingen zien</asp:ListItem>
                                    <asp:ListItem>Laat alle herkansingen zien</asp:ListItem>
                                    <asp:ListItem Value="Laat herkansings geschiedenis zien">Laat herkansings geschiedenis zien</asp:ListItem>
                                    <asp:ListItem>Laat alle zelf aangemaakte herkansingen zien</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                        </td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>

