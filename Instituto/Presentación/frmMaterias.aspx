<%@ Page Title="ABM de Materias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmMaterias.aspx.cs" Inherits="Instituto.Presentación.frmMaterias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" 
            Text="Gestor de Materias"></asp:Label>
</p>
<p>
    <asp:Label ID="Label1" runat="server" width="80px" Text="Id" Font-Bold="True"></asp:Label>
    <asp:TextBox ID="textoId" runat="server"></asp:TextBox>
</p>
    <p>
        
        <asp:Label ID="Nombre" runat="server" width="80px" Text="Nombre" 
            Font-Bold="True"></asp:Label>
        
        <asp:TextBox ID="textoNombre" runat="server"></asp:TextBox>
</p>
    <p>
        <asp:Button ID="btnAlta" runat="server" Text="Alta" OnClick="btnAlta_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBaja" runat="server" Text="Baja" OnClick="btnBaja_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
</p>
    <p>
        <asp:ListBox ID="lstMat" runat="server" Height="120px" Width="357px">
        </asp:ListBox>
        <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" OnClick="btnSeleccionar_Click" />
        <asp:Label ID="lblMensajes" runat="server" Text="."></asp:Label>
</p>
    <p>
        &nbsp;</p>
</asp:Content>
