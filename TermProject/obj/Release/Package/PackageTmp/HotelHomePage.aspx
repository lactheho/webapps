<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HotelHomePage.aspx.cs" Inherits="TermProject.HotelHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Background.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ul>
            <li><a class="active" href="HotelHomePage.aspx">Home</a></li>
            <li><a href="AirHomePage.aspx">Air Services</a></li>
            <li><a href="CarHomePage.aspx">Car Services</a></li>
            <li><a href="ActivitiesHomePage.aspx">Activities</a></li>
            <li><a href="HotelHomePage.aspx">Hotels</a></li>
        </ul>
          <div class="row" style="text-align: right">
            <asp:Button runat="server" ID="btnSignOut" Text="Sign Out" OnClick="btnSignOut_Click" Font-Size="X-Large" BorderStyle="Solid" BackColor="Red" ForeColor="White" />
        </div>
        <asp:Label runat="server" Font-Bold="true" ID="lblDirections">Select a city & state to display a list of hotel agencies.</asp:Label>
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

        <asp:Button runat="server" ID="btnGetHotels" Text="Get Hotels" OnClick="btnGetHotels_Click" />

        <asp:GridView runat="server" ID="gvHotels" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="Id" />
                <asp:BoundField HeaderText="Name" DataField="Name" />
                <asp:BoundField HeaderText="Street" DataField="Street" />
                <asp:BoundField HeaderText="City" DataField="City" />
                <asp:BoundField HeaderText="State" DataField="State" />
                <asp:BoundField HeaderText="ZipCode" DataField="ZipCode" />
                <asp:BoundField HeaderText="Amen_Bar" DataField="Amen_Bar" />
                <asp:BoundField HeaderText="Amen_BusinessFacilities" DataField="Amen_BusinessFacilities" />
                <asp:BoundField HeaderText="Amen_FreeBreakfast" DataField="Amen_FreeBreakfast" />
                <asp:BoundField HeaderText="Amen_FreeParking" DataField="Amen_FreeParking" />
                <asp:BoundField HeaderText="Amen_FreeWifi" DataField="Amen_FreeWifi" />
                <asp:BoundField HeaderText="Amen_Gym" DataField="Amen_Gym" />
                <asp:BoundField HeaderText="Amen_Pool" DataField="Amen_Pool" />
                <asp:BoundField HeaderText="Amen_Restaurant" DataField="Amen_Restaurant" />
                <asp:BoundField HeaderText="Amen_Spa" DataField="Amen_Spa" />
                <asp:BoundField HeaderText="StarRating" DataField="StarRating" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label runat="server" ID="lblDirections3" Font-Bold="true" Visible="false">Select one of the options.</asp:Label>
        <br />
        <asp:Button runat="server" ID="btnFindRoomsByAmen" Visible="false" Text="Find Room by Amenities" OnClick="btnFindRoomsByAmen_Click" />
        <asp:Button runat="server" ID="btnFindRoomsByID" Visible="false" Text="Find Room by ID" OnClick="btnFindRoomsByID_Click" />
        <br />
        <asp:Label runat="server" Text="Enter the Hotel ID to find available rooms." Font-Bold="true" ID="lblGetRoomByHotel" Visible="false"></asp:Label>
        <br />
        <asp:Label runat="server" Text="Hotel ID" ID="lblHotelID" Visible="false"></asp:Label>
        <asp:TextBox runat="server" ID="txtHotelID" Visible="false"></asp:TextBox>
        <asp:Button runat="server" ID="btnGetRooms" Text="Get Rooms By Hotel" Visible="false" OnClick="btnGetRooms_Click" />
        <br />
        <br />
        <asp:Label runat="server" ID="lblDirections2" Font-Bold="true" Visible="false">Select the room you wish to reserve.</asp:Label>
        <asp:GridView runat="server" ID="gvHotelRooms" AutoGenerateColumns="false" OnSelectedIndexChanged="gvHotelRooms_SelectedIndexChanged">
            <Columns>
                <asp:CommandField HeaderText="Reserve" ButtonType="Button" ShowSelectButton="true" />
                <asp:BoundField HeaderText="Id" DataField="Id" />
                <asp:BoundField HeaderText="HotelId" DataField="HotelId" />
                <asp:BoundField HeaderText="RoomNumber" DataField="RoomNumber" />
                <asp:BoundField HeaderText="PricePerNight" DataField="PricePerNight" />
                <asp:BoundField HeaderText="NumTwin" DataField="NumTwin" />
                <asp:BoundField HeaderText="NumQueen" DataField="NumQueen" />
                <asp:BoundField HeaderText="NumKing" DataField="NumKing" />
                <asp:BoundField HeaderText="Amen_Bathtub" DataField="Amen_Bathtub" />
                <asp:BoundField HeaderText="Amen_NonSmoking" DataField="Amen_NonSmoking" />
                <asp:BoundField HeaderText="Amen_PetFriendly" DataField="Amen_PetFriendly" />
                <asp:BoundField HeaderText="Amen_FutonAvailable" DataField="Amen_FutonAvailable" />
                <asp:BoundField HeaderText="Reserved" DataField="Reserved" />
            </Columns>
        </asp:GridView>

        <asp:Label runat="server" ID="lblFindRoom" Visible="false" Font-Bold="true" Text="Find Rooms By Amenities"></asp:Label>
        <br />
        <asp:Label runat="server" ID="lblRoomAmenities" Visible="false" Text="Room Amenities"></asp:Label>
        <asp:CheckBox runat="server" ID="cbxBathTub" Text="Bath Tub" Visible="false" />
        <asp:CheckBox runat="server" ID="cbxNonSmoking" Text="Non Smoking" Visible="false" />
        <asp:CheckBox runat="server" ID="cbxPetFriendly" Text="Pet Friendly" Visible="false" />
        <asp:CheckBox runat="server" ID="cbxFulton" Text="Fulton Available" Visible="false" />
        <br />

        <asp:Label runat="server" ID="lblHotelID2" Text="Hotel ID:" Visible="false"></asp:Label>
        <asp:TextBox runat="server" ID="txtHotelID2" Visible="false"></asp:TextBox>
        <asp:Button runat="server" ID="btnFindRoom" Text="Find Rooms By Amenities" Visible="false" OnClick="btnFindRoom_Click" />



    </form>
</body>
</html>
