<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MainMaster.Master" AutoEventWireup="true" CodeBehind="DisplayEmployees.aspx.cs" Inherits="TransportFrontEnd.WebForms.DisplayEmployees" %>

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
                    <h2>Employee Details</h2>
                    <hr />
                    <asp:ListView ID="lstEmployee" runat="server">
                        <LayoutTemplate>
                            <table runat="server" border="1">
                                <tr runat="server">
                                    <th runat="server">Employee Id</th>
                                    <th runat="server">Employee Name</th>
                                    <th runat="server">Employee Salary</th>
                                </tr>
                                <tr id="ItemPlaceHolder" runat="server" />
                            </table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("EmpId") %></td>
                                <td><%#Eval("EmpName") %></td>
                                <td><%#Eval("EmpSalary") %></td>

                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
