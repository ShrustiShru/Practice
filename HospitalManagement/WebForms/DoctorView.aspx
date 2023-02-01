<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/Main.Master" AutoEventWireup="true" CodeBehind="DoctorView.aspx.cs" Inherits="HospitalSoftware.WebForms.DoctorView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <h1 style="color:navy">List Of Patients!!!!!!</h1>
    Select: <asp:DropDownList ID="dpDoctors" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="dpDoctors_SelectedIndexChanged">
    </asp:DropDownList>
    <hr />
    <div class="container">
        <div class="row">
            <div class="col-md-4">
                <asp:TextBox TextMode="Search" ID="txtSearch" runat="server" CssClass="form-control" />
                <br />
                <asp:ListBox ID="lstPatients" runat="server" Height="401px" AutoPostBack="True" OnSelectedIndexChanged="lstPatients_SelectedIndexChanged" Width="226px" />
            </div>
            <div class="col-md-8">
                <h2>Details of the Patients</h2>
                <p>
                     PatientId: 
                    <asp:TextBox Enabled="false" runat="server" ID="txtId" CssClass="form-control" />
                </p>
                <p>
                    PatientName: 
                    <asp:TextBox Enabled="false" runat="server" ID="txtName" CssClass="form-control" />
                </p>
                <p>
                    Mobile No:
                    <asp:TextBox Enabled="false" TextMode="Number" ID="txtMobile" CssClass="form-control" runat="server" />
                </p>
                <p>
                    Age:
                    <asp:TextBox Enabled="false" TextMode="Number" ID="txtAge" CssClass="form-control" runat="server" />
                </p>
                <p>
                    <asp:Button Text="Diagnose" runat="server" ID="btnDiagnose" CssClass="btn btn-primary" />
                </p>
            </div>
        </div>
    </div>
</asp:Content>
