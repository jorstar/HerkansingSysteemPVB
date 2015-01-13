<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="UserControlls_Menu" %>
<div id="menu" class="menu">
    <asp:Menu ID="Hoofdmenu" runat="server" EnableViewState="False" Orientation="Horizontal">
        <Items>
            <asp:MenuItem Text="Home" Value="Home"></asp:MenuItem>
            <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            <asp:MenuItem Text="Uitloggen" Value="Uitloggen"></asp:MenuItem>
        </Items>
    </asp:Menu>
</div>