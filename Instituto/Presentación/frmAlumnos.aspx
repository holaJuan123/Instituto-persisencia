<%@ Page Title="ABM de Alumnos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAlumnos.aspx.cs" Inherits="Instituto.Presentación.frmAlumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <asp:Label ID="Label4" runat="server" Text="Gestor de Alumnos" Font-Bold="True"></asp:Label>
</p>
    <p>
        <asp:Label ID="Label1" width="80px" runat="server" Text="Id" Font-Bold="True"></asp:Label>
    <asp:TextBox ID="txtId" width="80px" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" width="80px" Text="Nombre" 
            Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtNombre" width="80px" runat="server"></asp:TextBox>
</p>
    <p>
        <asp:Label ID="Label3" width="80px"  runat="server" Text="Apellido" 
            Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtApellido" width="80px" runat="server"></asp:TextBox>
</p>
    <p>
        <asp:Button ID="btnAlta" runat="server" Text="Alta" OnClick="btnAlta_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBaja" runat="server" Text="Baja" OnClick="btnBaja_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMensajes" runat="server" Text="."></asp:Label>
</p>
    <p>
        <asp:ListBox ID="lstAlumnos" runat="server" Width="322px"></asp:ListBox>
        <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" OnClick="btnSeleccionar_Click" />
</p>
    <p>
        &nbsp;</p>
</asp:Content>
