<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmPrincipal.aspx.cs" Inherits="Instituto.Presentación.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<style>.main { background-color: black;} 
    body { background-color: red; }</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<center>
    <asp:Image ID="Image1" runat="server" 
        ImageUrl="~/Imagenes/diego1.JPG" Height="500px" ImageAlign="AbsMiddle" 
        style="margin-center: 229px" Width="400px" />
</center>

</asp:Content>
