﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Scripts.ascx.cs" Inherits="ProvaRegimental.Scripts" %>
<asp:ScriptManager runat="server">
    <Scripts>
        <%--To learn more about bundling scripts in ScriptManager see http://go.microsoft.com/fwlink/?LinkID=301884 --%>
        <%--Framework Scripts--%>
        <asp:ScriptReference Name="MsAjaxBundle" />
        <asp:ScriptReference Name="jquery" />
        <asp:ScriptReference Name="bootstrap" />
        <asp:ScriptReference Name="respond" />
        <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
        <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
        <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
        <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
        <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
        <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
        <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
        <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
        <asp:ScriptReference Name="WebFormsBundle" />
        <%--Site Scripts--%>
    </Scripts>
</asp:ScriptManager>
