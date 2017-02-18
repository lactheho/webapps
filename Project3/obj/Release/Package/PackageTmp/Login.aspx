<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style type="text/css">
        .auto-style1 {
            width: 174px;
            height: 26px;
            position: absolute;
            top: 367px;
            left: 497px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 428px;
            left: 513px;
            z-index: 1;
            height: 46px;
            width: 135px;
        }
        .auto-style4 {
            z-index: 1;
            top: 317px;
            position: absolute;
            left: 587px;
        }
        .auto-style5 {
            position: absolute;
            top: 319px;
            left: 460px;
            z-index: 1;
        }
    </style>
</head>
<body style="background-color:cadetblue">
    <form id="frmLogin" runat="server"  >
        <div style="height: 837px">
            <center>
         <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 10px; top: 15px; position: relative; text-align: center" Text="Welcome to Ticket Hub" Font-Size="X-Large" ForeColor="White"></asp:Label>
    
         <asp:Label ID="lblUserType" runat="server" Font-Size="Large" style="z-index: 1; left: 559px; top: 129px; position: absolute; text-align:center;" Text="Select a user type" ForeColor="White"></asp:Label>
         <asp:TextBox ID="txtUserName" runat="server" CssClass="auto-style4"></asp:TextBox>
         <asp:Button ID="btnNewUser" runat="server" OnClick="btnNewUser_Click" style="z-index: 1; left: 490px; top: 175px; position: absolute; height: 45px;" Text="New Customer" BackColor="#006699" BorderStyle="None" ForeColor="White" />
         <asp:Button ID="btnExistingUser" runat="server" OnClick="btnExistingUser_Click" style="z-index: 1; top: 175px; position: absolute; left: 633px; height: 45px;" Text="Existing Customer" BackColor="#0099CC" BorderStyle="None" ForeColor="White" />
                <asp:RadioButtonList ID="rblUserType" runat="server" CssClass="auto-style1" RepeatDirection="Horizontal" ForeColor="White">
                    <asp:ListItem Text="Buyer" Value="Buyer"></asp:ListItem>
                    <asp:ListItem Text="Seller" Value="Seller"></asp:ListItem>
                </asp:RadioButtonList>
         <asp:Label ID="lblInformation" runat="server" style="z-index: 1; left: 522px; top: 243px; position: absolute" Text="Enter your information" ForeColor="White"></asp:Label>
    
         <asp:Label ID="lblID" runat="server" style="z-index: 1; left: 470px; top: 281px; position: absolute" Text="ID:" ForeColor="White"></asp:Label>
         <asp:TextBox ID="txtID" runat="server" style="z-index: 1; left: 588px; top: 277px; position: absolute"></asp:TextBox>
    
                <asp:Button ID="btnSubmit" runat="server" CssClass="auto-style2" OnClick="btnSubmit_Click" Text="Submit" BackColor="#006600" BorderStyle="None" Font-Size="Large" ForeColor="White" />
                <asp:Label ID="lblUserName" runat="server" CssClass="auto-style5" Text="Username:" ForeColor="White"></asp:Label>
    
                <asp:RequiredFieldValidator ID="rfvID" runat="server" ControlToValidate="txtID" ErrorMessage="ID is a required field" style="z-index: 1; left: 747px; top: 279px; position: absolute" ForeColor="Red"></asp:RequiredFieldValidator>
    
                <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txtUserName" ErrorMessage="Username is a required field" style="z-index: 1; left: 750px; top: 316px; position: absolute" ForeColor="Red"></asp:RequiredFieldValidator>
    
                <asp:CompareValidator ID="cvdID" runat="server" ControlToValidate="txtID" Type="Integer" Operator="DataTypeCheck" ErrorMessage="ID must be an integer" ForeColor="Red" style="z-index: 1; left: 748px; top: 279px; position: absolute"></asp:CompareValidator>
    
                <asp:RequiredFieldValidator ID="rfvUsertype" runat="server" ControlToValidate="rblUserType" ErrorMessage="You must select one" ForeColor="Red" style="z-index: 1; left: 738px; top: 369px; position: absolute"></asp:RequiredFieldValidator>
    
    </center>


        </div>
    </form>
</body>
</html>
