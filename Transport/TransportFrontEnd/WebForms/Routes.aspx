<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MainMaster.Master" AutoEventWireup="true" CodeBehind="Routes.aspx.cs" Inherits="TransportFrontEnd.WebForms.Routes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .item {
            border: 2px solid blue;
        }
    </style>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <div>
                    <h2>Display Routes</h2>
                    <hr />
                    <asp:Menu runat="server">

                        <StaticItemTemplate>
                            <asp:Button runat="server" Text=' <%# Eval("Text") %>' CssClass="btn btn-danger" PostBackUrl='<%# Eval("NavigateUrl") %>'/> 
                            <asp:Button ID="btnDisplayRoute" class="btn btn-dark" Text="Display Route" runat="server" OnClick="btnDisplayRoute_Click" />
                        </StaticItemTemplate>
                        
                        <Items>
                            <asp:MenuItem  Text="Add Route" NavigateUrl="~/WebForms/AddRoutes.aspx"/>
                        </Items>
                    </asp:Menu>
                    <p> </p>

                    <asp:listview id="lstRoutes" runat="server" >
                        <LayoutTemplate>
                            <table runat="server" border="1">
                                <tr runat="server">
                                    <th runat="server">Route Number</th>
                                    <th runat="server">Route Name</th>
                                </tr>
                    <tr id="ItemPlaceHolder" runat="server" />
                            </table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("RouteNumber") %></td>
                                <td><%#Eval("RouteName1") %></td>

                            </tr>
                        </ItemTemplate>
                        
                    </asp:listview>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


<%--<asp:MenuItem ID="btnAddRoute" NavigateUrl="~/WebForms/AddRoutes.aspx" class="btn btn-info" Text="Add Route" runat="server"/>--%>
                    