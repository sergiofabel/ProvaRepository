﻿<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Relatorios.aspx.cs" Inherits="ProvaRegimental.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <form runat="server" class="form-horizontal">
        <div class="form-group">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Cod_cep" CssClass="table col-sm-12">
                <Columns>
                    <asp:BoundField DataField="Cod_cep" HeaderText="Cod_cep" ReadOnly="True" SortExpression="Cod_cep" />
                    <asp:BoundField DataField="Desc_cep" HeaderText="Desc_cep" SortExpression="Desc_cep" />
                    <asp:BoundField DataField="Lat_cep" HeaderText="Lat_cep" SortExpression="Lat_cep" />
                    <asp:BoundField DataField="Long_cep" HeaderText="Long_cep" SortExpression="Long_cep" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</asp:Content>
