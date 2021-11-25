<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCursos.aspx.cs" Inherits="Instituto.Presentación.frmCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <asp:Label ID="Label6" runat="server" Font-Bold="True" 
            Text="Creamos Curso de Cada Estudiante"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" width="80px" Text="Id" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" width="60px" Text="Seleccione Materia" 
            BorderColor="Black" Font-Bold="True"></asp:Label>
        &nbsp;&nbsp;&nbsp;      
        <asp:ListBox ID="lstMateria" runat="server" Width="150px"></asp:ListBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" width="60px" Text="Seleccione Alumno"  BorderColor="Black" Font-Bold="True"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstAlumno" runat="server" Width="150"></asp:ListBox>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" width="80px" Text="Año" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtAño" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" width="80px" Text="Nota" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnAlta" runat="server" OnClick="btnAlta_Click" width="80px" Text="Alta" />
        <asp:Button ID="btnBaja" runat="server" OnClick="btnBaja_Click" width="80px" Text="Baja" />
        <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" width="80px" Text="Modificar" />
        <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" width="80px" Text="Limpiar" />
        <asp:Button ID="btnSeleccionar" runat="server" OnClick="btnSeleccionar_Click" width="80px" Text="Seleccionar" />
    </p>
    <p>
        <asp:ListBox ID="lstCursos" runat="server" Width="450px"></asp:ListBox> 
    </p>
    <p>
        <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" Font-Size="Medium" 
            Height="10px">,</asp:Label>
    </p>

</asp:Content>
