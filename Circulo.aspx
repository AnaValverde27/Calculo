<%@ Page Title="Circulo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Circulo.aspx.cs" Inherits="calculo.Circulo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div>
        <label for="gradosInput">Radio del círculo:</label>
        <asp:TextBox ID="radioInput" runat="server"></asp:TextBox>
        <asp:Button ID="calcularButton" runat="server" Text="Calcular" OnClick="CalcularArea_Click" />
        <br />
        <span id="resultadoTexto" runat="server"></span>
    </div>
</asp:Content>