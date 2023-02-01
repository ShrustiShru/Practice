<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/Main.Master" AutoEventWireup="true" CodeBehind="Caching.aspx.cs" Inherits="HospitalSoftware.Caching.Caching" %>
<%@ OutputCache Duration="60" VaryByParam="City" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Time at the server: </h1>
    <hr />
    <asp:Label Text="" ID="lblTime" runat="server" />
    <div style="border:2px solid green">
        <h2>Time at Different Places</h2>
        <hr />
        <p>
            Select The City:
            <asp:DropDownList runat="server" ID="dpCities">
                <asp:ListItem Text="New Delhi"/>
                <asp:ListItem Text="London"/>
                <asp:ListItem Text="New York"/>     
                <asp:ListItem Text="Tokyo"/>
            </asp:DropDownList>
            <asp:Button Text="Get Time" ID="btnTime" runat="server" OnClick="btnTime_Click" />
            <asp:Label Text="" ID="lblClock" runat="server" />
        </p>
    </div>
</asp:Content>
