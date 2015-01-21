<%@ Page Title="Docent aanmaken" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="docentAanmaken.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="paginaContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <table style="text-align:center; width: 100%;">
        <tr>
            <td>

                <table style="width: 600px; margin: 50px auto 50px auto" class="fancyTable">
                    <tr>
                        <td>Voornaam<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Het veld voornaam is verplicht" ControlToValidate="txtVoornaam" ForeColor="Red">*</asp:RequiredFieldValidator>

                        </td>
                        <td class="herkansingAanmakenRightTableCollumn">
                            <asp:TextBox ID="txtVoornaam" CssClass="inputs" runat="server" Width="250px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Tussenvoegsel</td>
                        <td class="herkansingAanmakenRightTableCollumn">
                            <asp:TextBox ID="txtTussenvoegsel" CssClass="inputs" runat="server" Width="250px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Achternaam<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Het veld achternaam is verplicht" ControlToValidate="txtAchternaam" ForeColor="Red">*</asp:RequiredFieldValidator></td>
                        <td class="herkansingAanmakenRightTableCollumn">
                            <asp:TextBox ID="txtAchternaam" CssClass="inputs" runat="server" Width="250px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Afkorting<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtAfkorting" ErrorMessage="De afkortink more 3 Hoofd tekens and 2 leters zijn." ForeColor="Red" ValidationExpression="[A-Z]{3}\d{2}">*</asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Het veld afkorting is verplicht" ControlToValidate="txtAfkorting" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                        <td class="herkansingAanmakenRightTableCollumn">
                            <asp:TextBox ID="txtAfkorting" CssClass="inputs" runat="server" Width="250px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>E-mail<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEMail" ErrorMessage="Het opgegeven e-mail adres is ongelding" ForeColor="Red" ValidationExpression="^((?&gt;[a-zA-Z\d!#$%&amp;'*+\-/=?^_`{|}~]+\x20*|&quot;((?=[\x01-\x7f])[^&quot;\\]|\\[\x01-\x7f])*&quot;\x20*)*(?&lt;angle&gt;&lt;))?((?!\.)(?&gt;\.?[a-zA-Z\d!#$%&amp;'*+\-/=?^_`{|}~]+)+|&quot;((?=[\x01-\x7f])[^&quot;\\]|\\[\x01-\x7f])*&quot;)@(((?!-)[a-zA-Z\d\-]+(?&lt;!-)\.)+[a-zA-Z]{2,}|\[(((?(?&lt;!\[)\.)(25[0-5]|2[0-4]\d|[01]?\d?\d)){4}|[a-zA-Z\d\-]*[a-zA-Z\d]:((?=[\x01-\x7f])[^\\\[\]]|\\[\x01-\x7f])+)\])(?(angle)&gt;)$">*</asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Het veld e-mail is verplicht" ControlToValidate="txtEMail" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                        <td class="herkansingAanmakenRightTableCollumn">
                            <asp:TextBox ID="txtEMail" CssClass="inputs" runat="server" Width="250px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Wachtwoord<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Het veld wachtwoord is verplicht" ControlToValidate="txtWachtwoord" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                        <td class="herkansingAanmakenRightTableCollumn">
                            <asp:TextBox ID="txtWachtwoord" CssClass="inputs" runat="server" Width="250px" TextMode="Password"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="3" style="height: 50px;">
                            <asp:Button ID="btnBevestigen" CssClass="fancyButton" runat="server" Text="Bevestig" OnClick="btnBevestigen_Click" /></td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <div style=" margin: 10px auto 10px auto; width: 250px; text-align:left;">

                                <asp:ValidationSummary  ID="ValidationSummary1" runat="server" ForeColor="#FF0202" />

                            </div>
                        </td>
                    </tr>
                </table>

            </td>
        </tr>
    </table>

</asp:Content>


