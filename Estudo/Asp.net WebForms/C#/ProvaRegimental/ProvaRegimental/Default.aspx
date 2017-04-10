<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProvaRegimental._Default" %>

<%@ Register Src="Scripts.ascx" TagName="Scripts" TagPrefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>
        Manutenção de Cep
    </h3>
    <div class="container">
        <form runat="server" class="form-horizontal">
            <uc1:Scripts ID="Scripts1" runat="server" />
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Cod:" CssClass="col-sm-2 control-label" />
                <div class="col-sm-10">
                    <asp:TextBox ID="txtCod" runat="server" CssClass="form-control" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Desc:" CssClass="col-sm-2 control-label" />
                <div class="col-sm-10">
                    <asp:TextBox ID="txtDesc" runat="server" CssClass="form-control" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Lat:" CssClass="col-sm-2 control-label" />
                <div class="col-sm-10">
                    <asp:TextBox ID="txtLat" runat="server" CssClass="form-control" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Long:" CssClass="col-sm-2 control-label" />
                <div class="col-sm-10">
                    <asp:TextBox ID="txtLong" runat="server" CssClass="form-control" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-offset-2">
                    <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" CssClass="btn btn-default" />
                    <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" CssClass="btn btn-default" />
                    <asp:Button ID="btnEcluir" runat="server" Text="Excluir" OnClick="btnEcluir_Click" CssClass="btn btn-default" />
                    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" CssClass="btn btn-default" />
                    <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" CssClass="btn btn-default" />
                </div>
            </div>
            <div class="form-group">
                <p id="pMensagem" runat="server">
                    <asp:Label ID="lblMensagem" runat="server" Text="" CssClass=" control-label" />
                </p>
            </div>
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
    </div>
</asp:Content>
