 <%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MainMaster.Master" AutoEventWireup="true" CodeBehind="RecipiantPage.aspx.cs" Inherits="WebApplication.WebForms.RecipiantPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <h1>The Contents entered by the User are: </h1>
    <hr />
    <asp:Label Text="" ForeColor="Red" ID="lblMessage" runat="server" />
</asp:Content>