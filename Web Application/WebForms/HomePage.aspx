<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MainMaster.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication.WebForms.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <div class="container">
        <div class="row">
            <h1>Home Page of the Application</h1>
            <p>
                This page is an introduction to the Master Child concepts of ASP.NET Web Forms. 
                This allows to create Web pages in a more professional Manner....
            </p>
            
        <p><asp:Label ID="lblUserInfo" runat="server" /></p>
        <p><asp:Label ID="lblYear" runat="server" /></p>
            <asp:Button Text="Sign Out" ID="btnSignOut" runat="server" OnClick="btnSignOut_Click" />
        </div>
    </div>
</asp:Content>
