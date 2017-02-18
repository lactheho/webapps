<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturningCustomer.aspx.cs" Inherits="Project4.ReturningCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: burlywood">
    <form id="form1" runat="server">
        <div class="container">
            <div class="panel panel-default" style="margin-top: 2%">
                <div class="panel-heading" style="text-align: center"><strong>Buyer</strong></div>

                <div class="panel-body" style="text-align: left">
                    <div class="row">
                        <asp:Label runat="server" ID="lblInstructions">Enter your information.</asp:Label>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txtName" ErrorMessage="Username is a required field" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label ID="lblID" runat="server" Text="ID: "></asp:Label>
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvID" runat="server" ControlToValidate="txtID" ErrorMessage="ID is a required field" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cvdID" runat="server" ControlToValidate="txtID" Type="Integer" Operator="DataTypeCheck" ErrorMessage="ID must be an integer" ForeColor="Red"></asp:CompareValidator>
                    </div>
                    <br />
                    <div class="row">
                        <asp:RadioButtonList ID="rblUserType" runat="server" CssClass="auto-style6" RepeatDirection="Horizontal" ForeColor="White">
                            <asp:ListItem Text="Buyer" Value="Buyer"></asp:ListItem>
                            <asp:ListItem Text="Seller" Value="Seller"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label runat="server" ID="lblWarning" ForeColor="Red" Visible="false">Please try again.</asp:Label>
                    </div>
                    <div class="row">
                        <asp:Button runat="server" ID="btnSubmit" Text="Submit" BackColor="Green" OnClick="btnSubmit_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
