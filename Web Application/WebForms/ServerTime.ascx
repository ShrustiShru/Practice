<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ServerTime.ascx.cs" Inherits="WebApplication.ServerTime1" %>
<<%@ OutputCache Duration="60" VaryByParam="None" %>
<div>
    Time: 
    <asp:Label runat="server" ID="lblTime" BorderColor="Coral" />
</div>