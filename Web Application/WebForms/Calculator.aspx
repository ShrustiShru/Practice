<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="FirstWebApplication.Calculator" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>My Calculator</title>
</head>
<body style="background-color:lavender">
    <form id="form1" runat="server">
        <div>
            <h1>Calculator Program</h1>
            <hr />
            <p>
                Enter the First Value:
                <asp:TextBox runat="server" ID="FirstNo"/>
            </p>

            <p>
                Select the Operator
                <asp:DropDownList runat="server" ID="dropList">
                    <asp:ListItem Text="Addition" />
                    <asp:ListItem Text="Subtraction" />
                    <asp:ListItem Text="Multiplication" />
                    <asp:ListItem Text="Division" />
                </asp:DropDownList>
            </p>

            <p>
                Enter the Second Value:
                <asp:TextBox runat="server" ID="SecondNo" />
            </p>

            <p>
                <asp:Button Text="Get Result" runat="server" ID="btnResult" OnClick="btnResult_Click" />
            </p>

            <p>
                <asp:Label Text="The Result: " ID="lblDisplay" runat="server" />
            </p>
        </div>
    </form>
</body>
</html>
