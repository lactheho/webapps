<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="TermProject.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Background.css" rel="stylesheet" />
    <title></title>

    <script type="text/javascript">
        function displayNextImage() {
            x = (x === images.length - 1) ? 0 : x + 1;
            document.getElementById("Image1").src = images[x];
        }

        function displayPreviousImage() {
            x = (x <= 0) ? images.length - 1 : x - 1;
            document.getElementById("Image1").src = images[x];
        }

        function startTimer() {
            setInterval(displayNextImage, 5000);

        }

        var images = [], x = -1;
        images[0] = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/7cc5bf29502987.56055ba24155a.gif";
        images[1] = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/88aa1129502995.56055b4596b1a.gif";
        images[2] = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/edcf4c29503003.56055b42dc02a.gif";
        images[3] = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/db9eec29503011.56055ba09940f.gif";
        images[4] = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/9fe53529505867.56055bb6cd7a6.gif";
        images[5] = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/e2c8db29505903.56055aefbeed2.gif";

    </script>

</head>
<body onload="startTimer()">
    <form id="form1" runat="server">
        <div>
            <ul>
                <li><a class="active" href="HomePage.aspx">Home</a></li>
                <li><a href="AirHomePage.aspx">Air Services</a></li>
                <li><a href="CarHomePage.aspx">Car Services</a></li>
                <li><a href="ActivitiesHomePage.aspx">Activities</a></li>
                <li><a href="HotelHomePage.aspx">Hotels</a></li>
               

            </ul>
            <br />
            <br />
            <div class="row" style="text-align:right">
            <asp:Button runat="server" ID="btnSignOut" Text="Sign Out"  OnClick="btnSignOut_Click" Font-Size="X-Large" BorderStyle="Solid" BackColor="Red" ForeColor="White" />
                </div>
            <div class="row" style="text-align: center">
                <asp:Button runat="server" ID="btnViewCart" Text="View Cart" Font-Size="X-Large" BorderStyle="Solid" BackColor="#0099ff" ForeColor="White" OnClick="btnViewCart_Click" />
                <br /><br />
                <asp:Label runat="server" ID="lblAlert" Visible="false" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                <br /><br />
                <asp:GridView runat="server" Style="margin: auto" ID="gvTripItems" ShowFooter="true" FooterStyle-BackColor="#646464" CssClass="mydatagrid" PagerStyle-CssClass="pager"
                    HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" AutoGenerateColumns="false" OnRowEditing="gvTripItems_RowEditing" OnRowCancelingEdit="gvTripItems_RowCancelingEdit"
                    OnRowUpdating="gvTripItems_RowUpdating" OnRowDeleting="gvTripItems_RowDeleting">
                    <Columns>
                        <asp:BoundField HeaderText="Customer Name" DataField="CustomerName" ReadOnly="true" />
                        <asp:BoundField HeaderText="Item Type" DataField="TripItemTypes" ReadOnly="true" />
                        <asp:BoundField HeaderText="Item Name" DataField="TripItemName" ReadOnly="true" />
                        <asp:BoundField HeaderText="Item Description" DataField="TripItemDescription" ReadOnly="true" />
                        <asp:BoundField HeaderText="Item Price" DataField="TripItemPrice" ReadOnly="true" />
                        <asp:BoundField HeaderText="Quantity" DataField="Quantity" ReadOnly="true" />
                        <asp:BoundField HeaderText="Subtotal" DataField="Subtotal" ReadOnly="true" />
                        <asp:TemplateField HeaderText="Change Quantity">
                            <ItemTemplate>
                                <asp:TextBox runat="server" ID="txtQtyAdd"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField HeaderText="Edit Item" ButtonType="Button" ShowEditButton="true" />
                        <asp:CommandField HeaderText="Delete Item" ButtonType="Button" ShowDeleteButton="true" />
                    </Columns>
                </asp:GridView>
                <br />
                <asp:Button runat="server" ID="btnClear" Text="Clear Cart" Visble="false" OnClick="btnClear_Click" Visible="false" Font-Size="X-Large" BorderStyle="Solid" ForeColor="White" BackColor="#cc0000" />
                <asp:Button runat="server" ID="btnPurchase" Text="Purchase Vacation Package" Visble="false" OnClick="btnPurchase_Click" Visible="false" Font-Size="X-Large" BorderStyle="Solid" ForeColor="White" BackColor="#00cc66" />

            </div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />


            <footer>
                <center> <asp:Image ID="Image1" runat="server" Style="width: 550px; height: 100px; margin-right: 110px" ImageAlign="Middle" ImageUrl="https://mir-s3-cdn-cf.behance.net/project_modules/disp/e2c8db29505903.56055aefbeed2.gif" /></center>

            </footer>

        </div>
    </form>
</body>
</html>
