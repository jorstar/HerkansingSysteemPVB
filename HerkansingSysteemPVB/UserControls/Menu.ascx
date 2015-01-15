﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="UserControlls_Menu" %>
<div id="menu" class="menu">
    <asp:Menu ID="Hoofdmenu" runat="server" EnableViewState="False" Orientation="Horizontal" DynamicEnableDefaultPopOutImage="False" StaticEnableDefaultPopOutImage="False">
        <Items>
            <asp:MenuItem NavigateUrl="~/home.aspx" Text="Home" Value="Home"></asp:MenuItem>
            <asp:MenuItem Text="New Item" Value="New Item">
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/logoff.aspx" Text="Uitloggen" Value="Uitloggen"></asp:MenuItem>
        </Items>
        <StaticSelectedStyle  CssClass="selected" />
        <DynamicSelectedStyle CssClass="selected" />
    </asp:Menu>
</div>