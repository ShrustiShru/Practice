<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/Main.Master" AutoEventWireup="true" CodeBehind="RegisterPatient.aspx.cs" Inherits="HospitalSoftware.WebForms.RegisterPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Patient Registration</h1>
    <hr />
    <div class="container">
        <div class="row">
            <div class="col-md-10">
                <p>
                    PatientId:
                    <asp:TextBox ID="txtId" Enabled="false" placeholder="ID will be generated" runat="server" CssClass="form-control" />
                </p>
                <p>
                    Patient Name:
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
                </p>
                <p>
                    Mobile Number:
                    <asp:TextBox TextMode="Number" ID="txtMobile" runat="server" CssClass="form-control" />
                </p>
                <p>
                    Date of Birth:
                    <asp:TextBox TextMode="Date" ID="txtDob" runat="server" CssClass="form-control" />
                </p>
                <p>
                    DoctorName:
                    <asp:DropDownList ID="dpDoctors" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </p>
                <p>
                    <asp:Button Text="Register" runat="server" CssClass="btn btn-danger" OnClick="Unnamed1_Click" />
                </p>
                <p>
                    <asp:Label ID="lblMessage" runat="server" Text="" />
                </p>
            </div>
        </div>
    </div>
</asp:Content>
