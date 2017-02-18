<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="TermProject.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Background.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <h1>Registration Form</h1>
            </div>
            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lblDirections"><strong>Please fill out all fields to register.</strong></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lblLoginID">Email:</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txtLoginID"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfcLoginID" runat="server" ControlToValidate="txtLoginID" ErrorMessage="Email is a required field" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="EmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtLoginID" ForeColor="Red" ErrorMessage="Enter a valid email.">*</asp:RegularExpressionValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lblPassword">Password:</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is a required field" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lblName">Name:</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is a required field" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lblPhoneNumber">Phone Number:</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txtPhoneNumber"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" ErrorMessage="Phone Number is a required field" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="PhoneNumberValid" runat="server" ValidationExpression="^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$" ControlToValidate="txtPhoneNumber" ForeColor="Red" ErrorMessage="Enter a 10 digit phone number.">*</asp:RegularExpressionValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lblShipping">Shipping Address:</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txtShipping"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvShippingAddress" runat="server" ControlToValidate="txtShipping" ErrorMessage="Shipping Address is a required field" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lblPaymentOption">Payment Option: </asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RadioButtonList runat="server" ID="rblPayment" RepeatDirection="Horizontal" AutoPostBack="true" OnSelectedIndexChanged="rblPayment_SelectedIndexChanged">
                            <asp:ListItem Text="Credit" Value="Credit"></asp:ListItem>
                            <asp:ListItem Text="Debit" Value="Debit"></asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="rfvPaymentOption" runat="server" ControlToValidate="rblPayment" ErrorMessage="Select an option." ForeColor="Red">*</asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lblCardNumber" Visible="false">Card Number:</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txtCardNumber" Visible="false"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvCardNumber" runat="server" ControlToValidate="txtCardNumber" ErrorMessage="Card Number is a required field" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="CardNumberValid" runat="server" ValidationExpression="^[0-9]{16}$" ControlToValidate="txtCardNumber" ForeColor="Red" ErrorMessage="Enter a 16 Card Number.">*</asp:RegularExpressionValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lblExpirationDate" Visible="false">Expiration Date: </asp:Label>
                            <asp:Calendar runat="server" ID="calendar" Visible="false" AutoPostBack="true" OnSelectionChanged="calendar_SelectionChanged"></asp:Calendar>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lblSecurityCode" Visible="false">Security Code:</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txtSecurityCode" Visible="false"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvSecurityCode" runat="server" ControlToValidate="txtSecurityCode" ErrorMessage="Security Code is a required field" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="SecurityCodeValid" runat="server" ValidationExpression="^[0-9]{3}$" ControlToValidate="txtSecurityCode" ForeColor="Red" ErrorMessage="Enter a 3 digit security Code.">*</asp:RegularExpressionValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:CheckBox runat="server" ID="chkStoreCookie" Text="Store Cookie?" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button runat="server" ID="btnRegister" Text="Register" OnClick="btnRegister_Click" BackColor="Green" ForeColor="White" Font-Size="Large" BorderStyle="Solid" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button runat="server" ID="btnLoginPage" Text="Go To Login Page" OnClick="btnLoginPage_Click" BackColor="Blue" ForeColor="White" Font-Size="Large" BorderStyle="Solid" Visible="false" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:ValidationSummary runat="server" ID="ValidationSummary" ForeColor="Red" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Label runat="server" ID="lblSuccess" ForeColor="Green" Font-Size="Large" Visible="false">You have successfully registered.</asp:Label>
        </div>

    </form>
</body>
</html>
