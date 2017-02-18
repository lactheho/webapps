<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project4.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">


    <title>Login</title>
</head>
<body style="background-color: burlywood">
    <form id="form1" runat="server">
        <div class="container">
            <div class="panel panel-default" style="margin-top: 2%">
                <div class="panel-heading" style="text-align: center"><strong>Welcome to Electronics Auction House</strong></div>

                <div class="panel-body" style="text-align: center">
                    <div class="row">
                        <asp:Label ID="lblSignin" runat="server" Text="Sign in or register"></asp:Label>
                    </div>
                    <div>
                        <asp:Button ID="btnSignIn" runat="server" Text="Sign In" BackColor="YellowGreen" OnClick="btnSignIn_Click" />
                        <asp:Button ID="btnRegister" runat="server" Text="Register" BackColor="CornflowerBlue" OnClick="btnRegister_Click" />
                    </div>
                    <br />
                    <div>
                        <asp:Label ID="lblName" runat="server" Text="Name: " Visible="false"></asp:Label>
                        <asp:TextBox ID="txtName" runat="server" Visible="false" required="required"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txtName" ErrorMessage="Username is a required field" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <br />
                    <div>
                        <asp:Label ID="lblID" runat="server" Text="ID: " Visible="false"></asp:Label>
                        <asp:TextBox ID="txtID" runat="server" Visible="false" required="required"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="rfvID" runat="server" ControlToValidate="txtID" ErrorMessage="ID is a required field" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cvdID" runat="server" ControlToValidate="txtID" Type="Integer" Operator="DataTypeCheck" ErrorMessage="ID must be an integer" ForeColor="Red"></asp:CompareValidator>
                    </div>
                    <br />
                    <div>
                        <asp:Label ID="lblCustomerType" runat="server" Text="I am a:" Visible="false"></asp:Label>
                        <asp:DropDownList ID="ddlCustomerType" runat="server" Visible="false" required="required">
                            <asp:ListItem Text="Buyer" Value="Buyer"></asp:ListItem>
                            <asp:ListItem Text="Seller" Value="Seller"></asp:ListItem>
                            <asp:ListItem Text="Both" Value="Both"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <br />
                    <div>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn-success" Visible="false" OnClick="btnSubmit_Click" />
                    </div>

                </div>
                <br />

            </div>
        </div>
    </form>
</body>
</html>
