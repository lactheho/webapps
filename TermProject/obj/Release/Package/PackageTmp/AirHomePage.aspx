<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AirHomePage.aspx.cs" Inherits="TermProject.AirHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Background.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ul>
            <li><a class="active" href="HomePage.aspx">Home</a></li>
            <li><a href="AirHomePage.aspx">Air Services</a></li>
            <li><a href="CarHomePage.aspx">Car Services</a></li>
            <li><a href="ActivitiesHomePage.aspx">Activities</a></li>
            <li><a href="HotelHomePage.aspx">Hotels</a></li>
        </ul>
        <div class="row" style="text-align: right">
            <asp:Button runat="server" ID="btnSignOut" Text="Sign Out" OnClick="btnSignOut_Click" Font-Size="X-Large" BorderStyle="Solid" BackColor="Red" ForeColor="White" />
        </div>
        <asp:Label runat="server" Font-Bold="true" ID="lblDirections">Select a city & state for departure.</asp:Label>
        <br />
        <asp:Label runat="server" ID="lblCity">City</asp:Label>
        <asp:DropDownList runat="server" ID="ddlCity">
            <asp:ListItem Text="Philadelphia" Value="Philadelphia"></asp:ListItem>
            <asp:ListItem Text="Las Vegas" Value="Las Vegas"></asp:ListItem>
        </asp:DropDownList>

        <asp:Label runat="server" ID="lblState">State</asp:Label>
        <asp:DropDownList runat="server" ID="ddlState">
            <asp:ListItem Text="PA" Value="PA"></asp:ListItem>
            <asp:ListItem Text="NV" Value="NV"></asp:ListItem>
        </asp:DropDownList>

        <br />

        <asp:Label runat="server" Font-Bold="true" ID="lblDirections2">Select a city & state for arrival.</asp:Label>
        <br />
        <asp:Label runat="server" ID="lblCity2">City</asp:Label>
        <asp:DropDownList runat="server" ID="ddlCity2">
            <asp:ListItem Text="Philadelphia" Value="Philadelphia"></asp:ListItem>
            <asp:ListItem Text="Las Vegas" Value="Las Vegas"></asp:ListItem>
        </asp:DropDownList>

        <asp:Label runat="server" ID="lblState2">State</asp:Label>
        <asp:DropDownList runat="server" ID="ddlState2">
            <asp:ListItem Text="PA" Value="PA"></asp:ListItem>
            <asp:ListItem Text="NV" Value="NV"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button runat="server" ID="btnGetAirCarriers" Text="Get Air Carriers" OnClick="btnGetAirCarriers_Click" />
        <br />
        <br />
        <asp:GridView runat="server" ID="gvAirCarriers" AutoGenerateColumns="false" OnSelectedIndexChanged="gvAirCarriers_SelectedIndexChanged">
            <Columns>
                <asp:CommandField HeaderText="Select" ButtonType="Button" ShowSelectButton="true" />
                <asp:BoundField HeaderText="Carrier Name" DataField="CarrierName" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label runat="server" ID="lblDirection3" Text="Select a flight to book" Font-Bold="true" Visible="false"></asp:Label>
        <asp:GridView runat="server" ID="gvFlights" AutoGenerateColumns="false" OnSelectedIndexChanged="gvFlights_SelectedIndexChanged">
            <Columns>
                <asp:CommandField HeaderText="Select" ButtonType="Button" ShowSelectButton="true" />
                <asp:BoundField HeaderText="Flight Number" DataField="FlightNum" />
                <asp:BoundField HeaderText="CarrierID" DataField="CarrierID" />
                <asp:BoundField HeaderText="Departure City" DataField="DepartCity" />
                <asp:BoundField HeaderText="Departure State" DataField="DepartState" />
                <asp:BoundField HeaderText="Arrival City" DataField="ArriveCity" />
                <asp:BoundField HeaderText="Arrival State" DataField="ArriveState" />
                <asp:BoundField HeaderText="NonStop" DataField="NonStop" />
                <asp:BoundField HeaderText="Seating Type" DataField="SeatingType" />
                <asp:BoundField HeaderText="Price" DataField="Price" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label runat="server" ID="lbldirection2" Font-Bold="true" Visible="false" Text="Filter out your flights by carrier"></asp:Label>
        <br />
        <asp:CheckBox runat="server" ID="chkboxNonStop" Text="NonStop?" Visible="false" />
        <br />
        <br />
        <asp:Label runat="server" ID="lblSeatingType" Visible="false" Text="Filter by Seating Type"></asp:Label>
        <br />
        <asp:DropDownList runat="server" ID="ddlSeatingType" Visible="false">
            <asp:ListItem runat="server" Text="Economy" Value="Economy"></asp:ListItem>
            <asp:ListItem runat="server" Text="Business" Value="Business"></asp:ListItem>
            <asp:ListItem runat="server" Text="First Class" Value="First Class"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button runat="server" ID="btnFilter" Visible="false" Text="Filter Flights" OnClick="btnFilter_Click" />
        <%--     <asp:Label runat="server" Font-Bold="true" Visible="false" ID="lblDirections3">Select a air carrier you wish to rent</asp:Label>
        <asp:Label runat="server" ID="lblDirections4" Font-Bold="true" Visible="false">Select a air carrier.</asp:Label>   --%>
        <br />
    </form>
</body>
</html>
