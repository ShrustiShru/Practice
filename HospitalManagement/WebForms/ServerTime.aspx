<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/Main.Master" AutoEventWireup="true" CodeBehind="ServerTime.aspx.cs" Inherits="HospitalSoftware.WebForms.ServerTime" %>
<<%@ OutputCache Duration="60" VaryByParam="None" %>
<div>
    Time: 
    <asp:Label runat="server" ID="lblTime" BorderColor="Coral" />
</div>
