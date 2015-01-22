<%@ Page Title="Wachtwoord vergeten" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="WachtwoordVergeten.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" Runat="Server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div id="login">
                <table id="tablelogin" class="fancyTable" style="margin-top: 50px;">
                    <tr>
                        <td>Gebruikersnaam<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Gebruikersnaam is verplicht!" ControlToValidate="tbGebruikersnaam" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                        <td class="herkansingAanmakenRightTableCollumn">
                            <asp:TextBox ID="tbGebruikersnaam" placeholder="Gebruikersnaam" runat="server" CssClass="inputs"></asp:TextBox>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnLogin" runat="server" Text="Wachtwoord resetten" CssClass="fancyButton" OnClick="btnLogin_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <div style="width: 250px; text-align: left; margin: 5px auto">
                                <asp:Label ID="lblErrorMessage" runat="server" Text="" ForeColor="#FF0202" ></asp:Label>
                                <asp:ValidationSummary ID="ValidationSummary1" ForeColor="#FF0202" runat="server" />
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>

