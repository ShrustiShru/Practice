<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MainMaster.Master" AutoEventWireup="true" CodeBehind="AddRoutes.aspx.cs" Inherits="TransportFrontEnd.WebForms.AddRoutes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <h2>Add Routes</h2>
            <hr />
            <div class="col-md-8">
                Enter the Initial Station:<div class="col-md-8">
                    <asp:TextBox runat="server" ID="txtInitial" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <p></p>
            <hr />
            <div class="col-md-8">
                Enter the Final Station:<div class="col-md-8">
                    <asp:TextBox runat="server" ID="txtFinal" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <p></p>
            <div class="col-md-2">
                <asp:Button Text="Add Route" ID="btnAdd" runat="server" CssClass="form-control" OnClick="btnAdd_Click" />
            </div>

            <asp:Label runat="server" ID="lblSuccess"></asp:Label>
        </div>
    </div>
</asp:Content>
