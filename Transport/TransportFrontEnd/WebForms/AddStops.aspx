<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MainMaster.Master" AutoEventWireup="true" CodeBehind="AddStops.aspx.cs" Inherits="TransportFrontEnd.WebForms.AddStops" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <h2>Add New Stops</h2>
            <hr />
            <div class="col-md-8">
                Pick the Route:<div class="col-md-8">
                    <asp:DropDownList runat="server" ID="txtRoute" placeholder="Select the Route" CssClass="form-control" AutoPostBack="True" />
                </div>
            </div>
            <p></p>
            <hr />
            <div class="col-md-8">
                Enter the PickUp Station:<div class="col-md-8">
                    <asp:TextBox runat="server" ID="txtboxPick" placeholder="Enter the PickUp" CssClass="form-control" AutoPostBack="True"/>
                </div>
            </div>

            <p></p>

            <div class="col-md-8">
                Enter the Destination Station:
                <div class="col-md-8">
                    <asp:TextBox runat="server" placeholder="Enter the Drop" ID="txtboxDrop" CssClass="form-control" AutoPostBack="True"/>
                </div>
            </div>

            <div class="col-md-8">
                Enter the Price:
                <div class="col-md-8">
                    <asp:TextBox runat="server" placeholder="Enter the Price" ID="txtboxPrice" CssClass="form-control" AutoPostBack="True" />
                    <div class="col-md-2">
                        <p></p>
                        <asp:Button Text="Add" ID="btnAddStop" runat="server" CssClass="form-control" OnClick="btnAddStop_Click" />
                    </div>
                </div>
            </div>

            <asp:Label runat="server" ID="lblStop"></asp:Label>

        </div>
    </div>
</asp:Content>
