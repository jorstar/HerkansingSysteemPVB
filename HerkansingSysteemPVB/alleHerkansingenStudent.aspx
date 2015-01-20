<%@ Page Title="Overzicht herkansingen" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="alleHerkansingenStudent.aspx.cs" Inherits="_Default" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
    <table style="text-align: center; width: 100%;">
        <tr>
            <td>
                <table class="fancyTable" style="width: 900px; margin: 50px auto 50px auto;">
                    <tr>
                        <td colspan="2">
                            <asp:GridView CssClass="BlackTextGrid" ID="dgvStudentenHerkansingsOverzicht" Width="900px" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowCustomPaging="false" AllowPaging="true" PageSize="5" OnPageIndexChanging="dgvStudentenHerkansingsOverzicht_PageIndexChanging" OnRowDataBound="dgvStudentenHerkansingsOverzicht_RowDataBound" OnSelectedIndexChanged="dgvStudentenHerkansingsOverzicht_SelectedIndexChanged">
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
                            <br />
                            <asp:GridView CssClass="BlackTextGrid" ID="dgvStudentHerkansingOverzichtAlternatief" Visible="false" Width="900px" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowCustomPaging="false" AllowPaging="true" PageSize="5" OnPageIndexChanging="dgvStudentHerkansingOverzichtAlternatief_PageIndexChanging">
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
                                    <td>Om een herkansing te selecteren klik je op de desgewenste regel in de tabel.
                                        <br />
                                        Dan wordt je doorgestuurd en kun je alles nog eens rustig nakijken alvorens je op de bevestigings knop klikt.
                                    </td>
                                </tr>
                            </table>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div style="margin: 10px auto 10px auto; width: 297px;">
                                <asp:RadioButtonList Width="297px" ID="rdbVeranderDisplay" runat="server" AutoPostBack="True">
                                    <asp:ListItem Selected="True">Laat alle beschikbare herkansingen zien.</asp:ListItem>
                                    <asp:ListItem>Laat alle herkansingen zien.</asp:ListItem>
                                    <asp:ListItem>Laat alle herkansingen zien die zijn geweest.</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
