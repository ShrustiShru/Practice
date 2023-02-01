<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MainMaster.Master" AutoEventWireup="true" CodeBehind="Caching.aspx.cs" Inherits="WebApplication.WebForms.Caching" %>
<%@ Register TagName="CustomTime" TagPrefix="myCtrls" Src="~/WebForms/ServerTime.ascx" %>
<%--<%@ OutputCache Duration="60" VaryByParam="City"  %>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Time at the server:</h1>
    <hr />
    <asp:Label Text="" ID="lblTime" runat="server" />
    <div style="border: 2px solid green">
        <h2>Time at various places</h2>
        <hr />
        <p>
            Select UR City:
            <asp:DropDownList runat="server" ID="dpCities">
                <asp:ListItem Text="New Delhi" />
                <asp:ListItem Text="London" />
                <asp:ListItem Text="New York" />
                <asp:ListItem Text="Tokyo" />
            </asp:DropDownList>
            <asp:Button Text="GetTime" runat="server" ID="btnTime" OnClick="btnTime_Click" />
            <asp:Label Text="" ID="lblClock" runat="server" />
        </p>
    </div>
    <div>
        <myCtrls:CustomTime runat="server" />
    </div>

</asp:Content>
