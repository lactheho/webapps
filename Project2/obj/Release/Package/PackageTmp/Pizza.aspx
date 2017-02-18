<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pizza.aspx.cs" Inherits="Project2.Pizza" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>The Pizzeria</title>
    <style type="text/css">
        .text-danger {
            z-index: 1;
            left: 358px;
            top: 47px;
            position: absolute;
            height: 20px;
            width: 255px;
        }
    </style>
</head>
<body>
    <form id="frmPizza" runat="server">
    <div style="height: 1156px; margin-left: 0px; background-color: #003366;">
    



        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 450px; top: 15px; position: absolute" Text="Welcome to the Poppin' Pizzeria!" ForeColor="White"></asp:Label>
    
        <%-- labels for name, address, and phone number --%>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 10px; top: 49px; position: absolute" Text="Name:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 10px; top: 85px; position: absolute" Text="Address:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 10px; top: 121px; position: absolute" Text="Phone Number:" ForeColor="White"></asp:Label>

        <%-- textbox and validator for name --%>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 126px; top: 48px; position: absolute"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" CssClass="text-danger" Display="Static" ErrorMessage="You must enter a name." ForeColor="Red"></asp:RequiredFieldValidator>

        <%-- textbox and validator for address --%>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 125px; top: 87px; position: absolute"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress" style="z-index: 1; left: 358px; top: 86px; position: absolute" 
            CssClass="text-danger" Display="Static" ErrorMessage="You must enter an address." ForeColor="Red"></asp:RequiredFieldValidator>

        <%-- textbox and validator for phone number --%>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 124px; top: 121px; position: absolute"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" style="z-index: 1; left: 357px; top: 125px; position: absolute" 
            CssClass="text-danger" Display="Static" ErrorMessage="You must enter a phone number." ForeColor="Red"></asp:RequiredFieldValidator>
         
        <%-- label to takeout option --%>
        <asp:Label ID="lblSelection" runat="server" style="z-index: 1; left: 10px; top: 156px; position: absolute" Text="Please select an option:" ForeColor="White"></asp:Label>


        <asp:RadioButtonList ID="rbtTakeOut" runat="server" RepeatDirection="Horizontal" style="z-index: 1; left: 18px; top: 180px; position: absolute; height: 52px; width: 232px" ForeColor="White">
            <asp:ListItem Text="Delivery" Value="Delivery"></asp:ListItem>
            <asp:ListItem Text="Pick Up" Value="Pick Up"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="rfvTakeOut" runat="server" ControlToValidate="rbtTakeOut" Display="Dynamic" ErrorMessage="You must make a selection." ForeColor="Red" style="z-index: 1; left: 10px; top: 223px; position: absolute"></asp:RequiredFieldValidator>


        <asp:GridView ID="gvPizzaInput" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 10px; top: 255px; position: absolute; height: 133px; width: 187px; right: 562px;" BackColor="#006666" BorderColor="White" BorderStyle="Solid" ForeColor="White">
            <Columns>
                <asp:TemplateField HeaderText="Select Pizza">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkPizzaType" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Pizza Type" DataField="PizzaType" />
                <asp:TemplateField HeaderText="Size">
                    <ItemTemplate>
                        <asp:DropDownList ID="ddlSize" runat="server">
                            <asp:ListItem Text="Small" Value="Small"></asp:ListItem>
                            <asp:ListItem Text="Medium" Value="Medium"></asp:ListItem>
                            <asp:ListItem Text="Large" Value="Large"></asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>


        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 13px; top: 521px; position: absolute" Text="Submit" BorderStyle="Double" />
        


        <asp:Label ID="lblValidateQuantity" runat="server" style="z-index: 1; left: 10px; top: 482px; position: absolute; height: 16px;" Text="Label" ForeColor="Red"></asp:Label>


        <asp:GridView ID="gvPizzaOutput" runat="server" style="z-index: 1; left: 400px; top: 253px; position: absolute; height: 169px; width: 199px" AutoGenerateColumns="False" ShowFooter="True" BackColor="#006666" BorderColor="White" ForeColor="White">
            <Columns>
                <asp:BoundField HeaderText="Pizza Type" DataField="pizzaType" />
                <asp:BoundField HeaderText="Size" DataField="size" />
                <asp:BoundField HeaderText="Quantity" DataField="quantity" />
                <asp:BoundField HeaderText="Price" DataField="price" />
                <asp:BoundField HeaderText="Total Cost" DataField="totalCost" />
            </Columns>
        </asp:GridView>


        <asp:Label ID="lblValidateCheckbox" runat="server" ForeColor="Red" style="z-index: 1; left: 10px; top: 449px; position: absolute" Text="Label"></asp:Label>


        <asp:GridView ID="gvManagementReport" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 787px; top: 256px; position: absolute; height: 133px; width: 187px" BackColor="#006666" BorderColor="White" ForeColor="White">
            <Columns>
                <asp:BoundField HeaderText="Pizza Type" DataField="PizzaType" />
                <asp:BoundField HeaderText="Total Quantity" DataField="TotalQuantityOrdered" />
                <asp:BoundField HeaderText="Total Sales" DataField="TotalSales" />
            </Columns>
        </asp:GridView>


        <asp:Label ID="lblThankYou" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="White" style="z-index: 1; left: 401px; top: 454px; position: absolute" Text="Thank you! Enjoy your poppin' pizza!"></asp:Label>


    </div>
    </form>
</body>
</html>
