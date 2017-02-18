<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuyerPage.aspx.cs" Inherits="Project4.BuyerPage" %>

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
                        <asp:Label runat="server" ID="lblInstructions">Select a search filter.</asp:Label>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label runat="server" ID="lblCategory">Fliter by Category: </asp:Label>
                        <asp:DropDownList runat="server" ID="ddlCategory" AutoPostBack="true" OnSelectedIndexChanged="ddlFilter_SelectedIndexChanged">
                            <asp:ListItem Text="Smartphone" Value="Smartphone"></asp:ListItem>
                            <asp:ListItem Text="Laptop" Value="Laptop"></asp:ListItem>
                            <asp:ListItem Text="Computer" Value="Computer"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label runat="server" ID="lblReservePrice">Filter by Reserve Price:</asp:Label>
                        <asp:DropDownList runat="server" ID="ddlReservePrice" AutoPostBack="true" OnSelectedIndexChanged="ddlReservePrice_SelectedIndexChanged">
                            <asp:ListItem Text="Low to High" Value="Low To High"></asp:ListItem>
                            <asp:ListItem Text="High to Low" Value="High to Low"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label runat="server" ID="lblBidPrice">Filter by Bid Price:</asp:Label>
                        <asp:DropDownList runat="server" ID="ddlBidPrice" AutoPostBack="true" OnSelectedIndexChanged="ddlBidPrice_SelectedIndexChanged">
                            <asp:ListItem Text="High to Low" Value="High to Low"></asp:ListItem>
                            <asp:ListItem Text="Low to High" Value="Low to High"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <br />
                    <br />
                    <div class="row">
                        <asp:Label runat="server" ID="lblSuccess" ForeColor="Green" Visible="false">You have successfully placed a bid!</asp:Label>
                        <asp:Label runat="server" ID="lblSold" ForeColor="Green" Visible="false">Congratulations! You have bought the item!</asp:Label>
                        <asp:GridView runat="server" ID="gvProducts" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField HeaderText="Description" DataField="Description" />
                                <asp:BoundField HeaderText="Category" DataField="Category" />
                                <asp:BoundField HeaderText="Reserve Price" DataField="ReservePrice" />
                                <asp:BoundField HeaderText="Current Bid Price" DataField="BidPrice" />
                                <asp:BoundField HeaderText="End Date" DataField="EndDate" />
                            </Columns>
                        </asp:GridView>
                        <br />
                        <asp:Label runat="server" ID="lblDescription">Description of Product you wish to bid: </asp:Label>
                        <asp:TextBox runat="server" ID="txtDescription"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label runat="server" ID="lblBidAmount">Bid Amount: </asp:Label>
                        <asp:TextBox runat="server" ID="txtBidAmount"></asp:TextBox>
                        <asp:Label runat="server" ID="lblValidateBid" ForeColor="Red" Visible="false"><strong>Bid amount must be higher than current bid.</strong></asp:Label>
                    </div>
                    <div class="row">
                        <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
