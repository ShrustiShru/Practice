<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MainMaster.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApplication.WebForms.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <div style="text-align:center; height:190px; width:432px;">
        <h2>User Login</h2>
        <hr />
        <p>
            UserName: <asp:TextBox runat="server" ID="txtUserName" Height="22px" Width="239px" />
        </p>

        <p>
            Password:<asp:TextBox runat="server" id="txtPassword" TextMode="Password" Height="21px" Width="247px" />
        </p>

        <p>
            <asp:Button Text="Login" runat="server" ID="btnLogin" OnClick="btnLogin_Click" />
        </p>

        <p>
            <asp:label id="lblError" runat="server" ForeColor="red" />
        </p>

        <p>
            <asp:Label ID="lblUserInfo" runat="server" />
        </p>

        <p>
            <asp:Label ID="lblYear" runat="server" />
        </p>
    </div>
</asp:Content>
