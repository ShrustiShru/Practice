<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MainMaster.Master" AutoEventWireup="true" CodeBehind="BookTicket.aspx.cs" Inherits="TransportFrontEnd.WebForms.BookTicket" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <h2>Booking Ticket</h2>
            <hr />
            <div class="col-md-8">
                Enter the Route:<div class="col-md-8">
                    <asp:DropDownList runat="server" ID="txtRoute" placeholder="Select the Route" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="txtRoute_SelectedIndexChanged"/>
                </div>
            </div>
            <p></p>
            <hr />
            <div class="col-md-8">
                Enter the PickUp Station:<div class="col-md-8">
                    <asp:DropDownList runat="server" ID="txtPick" placeholder="Select the PickUp" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="txtPick_SelectedIndexChanged"/>
                </div>
            </div>

            <p></p>

            <div class="col-md-8">
                Enter the Destination Station:<div class="col-md-8">
                    <asp:DropDownList runat="server" placeholder="Select the Drop" ID="txtDrop" CssClass="form-control" OnSelectedIndexChanged="txtDrop_SelectedIndexChanged" AutoPostBack="True" />
                    <p></p>
                    Fair:
                     <asp:Label runat="server" id="lblBook" CssClass="form-control"/>
                    <div class="col-md-2">
                        <p></p>
                        <asp:Button Text="Book" ID="btnBook" runat="server" CssClass="form-control" OnClick="btnBook_Click"  />
                    </div>
                </div>

               
            </div>
        </div>
    </div>
</asp:Content>
