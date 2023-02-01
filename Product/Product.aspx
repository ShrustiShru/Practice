<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Products.cs.Product" Trace="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
</head>
<body>
    <h1 class="h1 text-danger">Product Database</h1>
    <hr />
    <form id="form1" runat="server">
        <div class="container">
            <div class="row d-flex ">
                <div class="col-md-4">
                    <asp:ListBox ID="lstProducts" runat="server" Height="386px" Width="213px" OnSelectedIndexChanged="lstProducts_SelectedIndexChanged" AutoPostBack="true" ></asp:ListBox>
                </div>

                <div class="col-md-7">
                    <h2>Product Details</h2>
                    <div class="row">
                        <div class="col-md-6">
                            <asp:Image ID="Image" runat="server" Height="253px" Width="225px" />
                        </div>

                        <div class="col-md-4">
                            <p>
                                Name:
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
                            </p>
                            <p>
                                Price:
                                <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" />
                            </p>
                            <p>
                                Quantity:
                                <asp:DropDownList ID="dpQuantity" runat="server" CssClass="form-control">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                </asp:DropDownList>
                            </p>
                        </div>

                    <div class="col-md-2 align-items-centre">
                        <button runat="server" class="btn btn-info m-2">
                            <i class="fa fa-pencil"></i>
                            </button>
                        <button runat="server"  class="btn btn-danger m-2">
                            <i class="fa fa-trash"></i>
                            </button>
                    </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
