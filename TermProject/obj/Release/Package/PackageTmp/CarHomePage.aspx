<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarHomePage.aspx.cs" Inherits="TermProject.CarServicesHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Background.css" rel="stylesheet" />
    <title>Car Services</title>
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
        <asp:Label runat="server" Font-Bold="true" ID="lblDirections">Select a city & state to display a list of car agencies.</asp:Label>
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

        <asp:Button runat="server" ID="btnGetCarAgencies" Text="Get Car Agencies" OnClick="btnGetCarAgencies_Click" />
        <br />
        <br />
        <asp:Label runat="server" Font-Bold="true" Visible="false" ID="lblDirections3">Select a car you wish to rent</asp:Label>
        <asp:Label runat="server" ID="lblDirections4" Font-Bold="true" Visible="false">Select a car agency.</asp:Label>
        <br />
        <asp:GridView runat="server" ID="gvCarAgencies" AutoGenerateColumns="false" OnSelectedIndexChanged="gvCarAgencies_SelectedIndexChanged">
            <Columns>
                <asp:CommandField HeaderText="Select" ButtonType="Button" ShowSelectButton="true" />
                <asp:BoundField HeaderText="Agency ID" DataField="AgencyID" />
                <asp:BoundField HeaderText="Agency Name" DataField="AgencyName" />
                <asp:BoundField HeaderText="City" DataField="City" />
                <asp:BoundField HeaderText="State" DataField="State" />
            </Columns>
        </asp:GridView>
        <asp:GridView runat="server" ID="gvCars" AutoGenerateColumns="false" OnSelectedIndexChanged="gvCars_SelectedIndexChanged">
            <Columns>
                <asp:CommandField HeaderText="Rent" ButtonType="Button" ShowSelectButton="true" />
                <asp:BoundField HeaderText="City" DataField="City" />
                <asp:BoundField HeaderText="State" DataField="State" />
                <asp:BoundField HeaderText="Car Agency" DataField="AgencyName" />
                <asp:BoundField HeaderText="Agency ID" DataField="AgencyID" />
                <asp:BoundField HeaderText="CarID" DataField="CarID" />
                <asp:BoundField HeaderText="CarName" DataField="CarName" />
                <asp:BoundField HeaderText="Price" DataField="CarPricePerDay" />
            </Columns>
        </asp:GridView>
        <asp:Label runat="server" Font-Bold="true" ID="lblDirections2" Visible="false">Select the requirements you want for your Car Rental. If no cars are displayed, select other requirements.</asp:Label>
        <br />
        <asp:CheckBox runat="server" ID="cbxFourDoors" Text="Four Doors?" Visible="false" />
        <br />
        <asp:CheckBox runat="server" ID="cbxAutomatic" Text="Automatic?" Visible="false" />
        <br />
        <asp:CheckBox runat="server" ID="cbxSUV" Text="SUV?" Visible="false" />
        <br />
        <asp:CheckBox runat="server" ID="cbx30MPG" Text="30 MPG in City?" Visible="false" />
        <br />
        <asp:Button runat="server" ID="btnSubmit2" Text="Submit" OnClick="btnSubmit2_Click" Visible="false" />

    </form>
</body>
</html>
