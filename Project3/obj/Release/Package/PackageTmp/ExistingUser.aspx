<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExistingUser.aspx.cs" Inherits="Project3.ExistingUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Existing User</title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 75px;
            left: 438px;
        }
        .auto-style4 {
            position: absolute;
            top: 122px;
            left: 398px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 119px;
            left: 496px;
            z-index: 1;
        }
        .auto-style6 {
            width: 207px;
            height: 26px;
            position: absolute;
            top: 208px;
            left: 422px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 285px;
            left: 457px;
            z-index: 1;
            height: 49px;
            width: 124px;
        }
    </style>
</head>
<body style="background-color:cadetblue">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblInformation" runat="server" CssClass="auto-style1" style="z-index: 1" Text="Please enter your information" ForeColor="White"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" CssClass="auto-style4" Text="Username:" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" CssClass="auto-style5"></asp:TextBox>
        <asp:RadioButtonList ID="rblUserType" runat="server" CssClass="auto-style6" RepeatDirection="Horizontal" ForeColor="White">
            <asp:ListItem Text="Buyer" Value ="Buyer"></asp:ListItem>
            <asp:ListItem Text="Seller" Value="Seller"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="btnSubmit" runat="server" CssClass="auto-style7" OnClick="btnSubmit_Click" Text="Submit" BackColor="#006600" BorderStyle="None" ForeColor="White" />
        <asp:Label ID="lblWarning" runat="server" style="z-index: 1; left: 424px; top: 244px; position: absolute" Text="Record not found. Please try again." ForeColor="White"></asp:Label>
        <asp:Label ID="lblExistingUser" runat="server" Font-Size="X-Large" ForeColor="White" style="z-index: 1; left: 472px; top: 17px; position: absolute" Text="Existing User"></asp:Label>
        <asp:Label ID="lblID" runat="server" ForeColor="White" style="z-index: 1; left: 423px; top: 156px; position: absolute" Text="ID:"></asp:Label>
        <asp:TextBox ID="txtID" runat="server" style="z-index: 1; left: 496px; top: 152px; position: absolute"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUserName" ErrorMessage="Username is a required field" ForeColor="Red" style="z-index: 1; left: 652px; top: 120px; position: absolute"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="rfvID" runat="server" ControlToValidate="txtID" ErrorMessage="ID is a required field" ForeColor="Red" style="z-index: 1; left: 660px; top: 153px; position: absolute"></asp:RequiredFieldValidator>
        <asp:CompareValidator runat="server" ControlToValidate="txtID" Type="Integer" Operator="DataTypeCheck" ErrorMessage="ID must be an integer" ForeColor="Red" style="z-index: 1; left: 661px; top: 153px; position: absolute"></asp:CompareValidator>
        <asp:RequiredFieldValidator ID="rfvUsertype" runat="server" ControlToValidate="txtID" ErrorMessage="You must select one" ForeColor="Red" style="z-index: 1; left: 661px; top: 209px; position: absolute"></asp:RequiredFieldValidator>
    </form>
</body>
</html>
