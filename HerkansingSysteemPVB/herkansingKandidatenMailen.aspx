<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="herkansingKandidatenMailen.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">

    <table style="text-align: center; width: 100%;">
        <tr>
            <td>

                <table style="width: 600px; margin: 50px auto 50px auto">
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddlHerkansingen" runat="server"></asp:DropDownList>
                            <asp:GridView ID="dgvKandidaten" runat="server"></asp:GridView>
                            <hr />

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:EntityDataSource ID="EntityDataSource1" runat="server"></asp:EntityDataSource>
                            <asp:ListView ID="lvStudenten" runat="server"></asp:ListView>
                        </td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>
