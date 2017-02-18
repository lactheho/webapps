<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SellerPage.aspx.cs" Inherits="Project4.SellerPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">


    <title>Seller</title>
</head>
<body style="background-color: burlywood">
    <form id="form1" runat="server">
        <div class="container">
            <div class="panel panel-default" style="margin-top: 2%">
                <div class="panel-heading" style="text-align: center"><strong>Seller</strong></div>

                <div class="panel-body" style="text-align: left">
                    <div class="row">
                        <asp:Label runat="server" ID="lblInstructions">Enter the product information you wish to sell.</asp:Label>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label runat="server" ID="lblDescription">Product Description </asp:Label>
                        <asp:TextBox runat="server" ID="txtDescription"></asp:TextBox>
                        <asp:Label runat="server" ID="lblCategory">Category </asp:Label>
                       <asp:DropDownList runat="server" ID="ddlCategory">
                            <asp:ListItem Text="Smartphone" Value="Smartphone"></asp:ListItem>
                            <asp:ListItem Text="Laptop" Value="Laptop"></asp:ListItem>
                            <asp:ListItem Text="Computer" Value="Computer"></asp:ListItem>
                       </asp:DropDownList>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label runat="server" ID="lblReservePrice">Reserve Price </asp:Label>
                        <asp:TextBox runat="server" ID="txtReservePrice"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label runat="server" ID="lblEndDate">Auction End Date </asp:Label>
                        <asp:Calendar runat="server" ID="EndDateCalendar" OnSelectionChanged="EndDateCalendar_SelectionChanged" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px" >
                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
                            <DayStyle Width="14%" />
                            <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                            <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                            <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                            <TodayDayStyle BackColor="#CCCC99" />
                        </asp:Calendar>
                    </div>
                    <div class="row">
                        <asp:Label runat="server" ID="lblSelectedDate"><strong>You selected: </strong></asp:Label>
                        <asp:Label runat="server" ID="lblDate"></asp:Label>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label runat="server" ID="lblSuccess" ForeColor="Green" Visible="false">You have successfully added an item to the auction.</asp:Label>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
