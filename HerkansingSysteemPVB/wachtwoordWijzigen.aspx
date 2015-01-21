<%@ Page Title="Wachtwoord wijzigen" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="wachtwoordWijzigen.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    <table style="text-align: center; width: 100%;">
        <tr>
            <td>

                <table class="fancyTable" style="width: 600px; margin: 50px auto 50px auto;">
                    <tr>
                        <td style="width: 50%;">Het oude wachtwoord<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOldPass" ErrorMessage="Het oude wachtwoord is verplicht" ForeColor="Red">*</asp:RequiredFieldValidator>

                            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtOldPass" ControlToValidate="txtNewPass" ErrorMessage="Het oude wachtwoord en het nieuwe mogen niet overeen komen" ForeColor="Red" Operator="NotEqual">*</asp:CompareValidator>

                        </td>
                        <td class="herkansingAanmakenRightTableCollumn">

                            <asp:TextBox ID="txtOldPass" CssClass="inputs" Width="250px" runat="server" TextMode="Password"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>Het nieuwe wachtwoord<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNewPass" ControlToValidate="txtNewPassCheck" ErrorMessage="Nieuwe wachtwoorden komen niet overeen" ForeColor="Red">*</asp:CompareValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNewPass" ErrorMessage="Geen nieuw wachtwoord opgegeven" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                        <td class="herkansingAanmakenRightTableCollumn">

                            <asp:TextBox ID="txtNewPass" CssClass="inputs" runat="server" Width="250px" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Het nieuwe wachtwoord (check)<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNewPassCheck" ErrorMessage="Geen check voor het nieuwe wachtwoord opgegeven" ForeColor="Red">*</asp:RequiredFieldValidator>

                        </td>
                        <td class="herkansingAanmakenRightTableCollumn">

                            <asp:TextBox ID="txtNewPassCheck" CssClass="inputs" runat="server" Width="250px" TextMode="Password"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                     <tr>
                        <td colspan="2">
                            <asp:Button ID="btnBevestig" CssClass="fancyButton" runat="server" Text="Wachtwoord wijzigen" OnClick="btnBevestig_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="padding: 10px 0; text-align:center;">
                            <div style="margin: 0 auto; width: 400px; text-align:left">
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF0202" />
                            </div>
                        </td>
                    </tr>

                </table>

            </td>
        </tr>
    </table>

</asp:Content>