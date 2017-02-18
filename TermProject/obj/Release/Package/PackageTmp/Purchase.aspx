<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Purchase.aspx.cs" Inherits="TermProject.Purchase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Background.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li><a class="active" href="HomePage.aspx">Home</a></li>
                <li><a href="AirHomePage.aspx">Air Services</a></li>
                <li><a href="CarHomePage.aspx">Car Services</a></li>
                <li><a href="ActivitiesHomePage.aspx">Activities</a></li>
                <li><a href="HotelHomePage.aspx">Hotels</a></li>
            </ul>

            <center><h1>Check Out</h1></center>
            <br />
            <div class="row" style="text-align: right">
                <asp:Button runat="server" ID="btnSignOut" Text="Sign Out" OnClick="btnSignOut_Click" Font-Size="X-Large" BorderStyle="Solid" BackColor="Red" ForeColor="White" />
            </div>
            <div class="row" style="text-align: center">
                <asp:Label runat="server" ID="lblDisplay" Visible="false" Font-Size="X-Large" ForeColor="Green"></asp:Label>
                <asp:GridView ID="gvPurchase" runat="server" AutoGenerateColumns="false" Style="margin: auto" CellPadding="4" CssClass="mydatagrid" PagerStyle-CssClass="pager"
                    HeaderStyle-CssClass="header" RowStyle-CssClass="rows" ShowFooter="true">
                    <Columns>
                        <asp:BoundField HeaderText="Item Type" DataField="TripItemTypes" ReadOnly="true" />
                        <asp:BoundField HeaderText="Item Name" DataField="TripItemName" ReadOnly="true" />
                        <asp:BoundField HeaderText="Item Description" DataField="TripItemDescription" ReadOnly="true" />
                        <asp:BoundField HeaderText="Item Price" DataField="TripItemPrice" ReadOnly="true" />
                        <asp:BoundField HeaderText="Quantity" DataField="Quantity" ReadOnly="true" />
                        <asp:BoundField HeaderText="Subtotal" DataField="Subtotal" ReadOnly="true" />
                    </Columns>
                </asp:GridView>
                <br />
                <asp:Button runat="server" ID="btnPurchase" Text="Confirm Purchase" Visble="false" OnClick="btnPurchase_Click" Font-Size="X-Large" BorderStyle="Solid" ForeColor="White" BackColor="#00cc66" />
                <br />
                <asp:Button runat="server" ID="btnViewPurchase" Text="View Purchase" OnClick="btnViewPurchase_Click" Font-Size="X-Large" BorderStyle="Solid" ForeColor="White" BackColor="#3399ff" Visible="false" />
                <br />
                <br />
                <asp:GridView ID="gvVacationPackage" runat="server" OnRowDeleting="gvVacationPackage_RowDeleting" AutoGenerateColumns="false" Style="margin: auto" CellPadding="4" CssClass="mydatagrid" PagerStyle-CssClass="pager"
                    HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
                    <Columns>
                        <asp:BoundField HeaderText="Air Service" DataField="AirService" ReadOnly="true" />
                        <asp:BoundField HeaderText="Air Service Description" DataField="AirServiceDescription" ReadOnly="true" />
                        <asp:BoundField HeaderText="Car Service" DataField="CarService" ReadOnly="true" />
                        <asp:BoundField HeaderText="Car Service Description" DataField="CarServiceDescription" ReadOnly="true" />
                        <asp:BoundField HeaderText="Hotel Service" DataField="HotelService" ReadOnly="true" />
                        <asp:BoundField HeaderText="Hotel Service Description" DataField="HotelServiceDescription" ReadOnly="true" />
                        <asp:BoundField HeaderText="Activity Service" DataField="ActivityService" ReadOnly="true" />
                        <asp:BoundField HeaderText="Activity Service Description" DataField="ActivityServiceDescription" ReadOnly="true" />
                        <asp:BoundField HeaderText="Total Quantity" DataField="Quantity" ReadOnly="true" />
                        <asp:BoundField HeaderText="Sales Total" DataField="TotalSales" ReadOnly="true" />
                        <asp:CommandField HeaderText="Delete Item" ButtonType="Button" ShowDeleteButton="true" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
