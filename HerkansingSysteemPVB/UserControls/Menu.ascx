<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="UserControlls_Menu" %>
<div id="menu" class="menu">
    <asp:Menu ID="Hoofdmenu" runat="server" EnableViewState="False" Orientation="Horizontal" DynamicEnableDefaultPopOutImage="False" StaticEnableDefaultPopOutImage="False">
        <Items>
            <asp:MenuItem NavigateUrl="~/home.aspx" Text="Home" Value="Home"></asp:MenuItem>
            <asp:MenuItem Text="Aanmaken" Value="AanmakenDocent">
                <asp:MenuItem Text="Vak" Value="VakDocent" NavigateUrl="~/vakAanmaken.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Toets" Value="ToetsDocent" NavigateUrl="~/toetsAanmaken.aspx"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/herkansingAanmaken.aspx" Text="Herkansing" Value="HerkansingDocent"></asp:MenuItem>
            </asp:MenuItem>
<asp:MenuItem Text="Aanmaken" Value="AanmakenBeheer">
    <asp:MenuItem NavigateUrl="~/docentAanmaken.aspx" Text="Leraar" Value="LeraarBeheer"></asp:MenuItem>
    <asp:MenuItem NavigateUrl="~/lokaalToevoegen.aspx" Text="Lokaal" Value="LokaalBeheer"></asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem Text="Herkansing overzicht" Value="HerkansingOverzichtStudent" NavigateUrl="~/alleHerkansingenStudent.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Aanmelden voor een herkansing" Value="AanmeldenHerkansing" NavigateUrl="~/alleHerkansingenStudent.aspx"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/logoff.aspx" Text="Uitloggen" Value="Uitloggen"></asp:MenuItem>
        </Items>
        <StaticSelectedStyle  CssClass="selected" />
        <DynamicSelectedStyle CssClass="selected" />
    </asp:Menu>
</div>