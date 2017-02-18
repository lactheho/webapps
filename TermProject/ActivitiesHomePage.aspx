<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActivitiesHomePage.aspx.cs" Inherits="TermProject.ActivitiesHomePage" %>

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
        <asp:Label runat="server" Font-Bold="true" ID="lblDirections">Select a city & state to display a list of activity agencies.</asp:Label>
        <br />
        <asp:Label runat="server" ID="lblCity">City</asp:Label>
        <asp:DropDownList runat="server" ID="ddlCity">
            <asp:ListItem Text="Philadelphia" Value="Philadelphia"></asp:ListItem>
            <asp:ListItem Text="Las Vegas" Value="Las Vegas"></asp:ListItem>
            <asp:ListItem Text="Pittsburgh" Value="Pittsburgh"></asp:ListItem>
        </asp:DropDownList>

        <asp:Label runat="server" ID="lblState">State</asp:Label>
        <asp:DropDownList runat="server" ID="ddlState">
            <asp:ListItem Text="PA" Value="PA"></asp:ListItem>
            <asp:ListItem Text="NV" Value="NV"></asp:ListItem>
        </asp:DropDownList>

        <asp:Button runat="server" ID="btnSearch" Text="Search" OnClick="btnSearch_Click" />
        <asp:Label runat="server" Font-Bold="true" Visible="false" ID="lblDirections3">Select a car you wish to rent</asp:Label>
        <br />
        <br />
        <asp:Label runat="server" ID="lblDirections4" Visible="false" Font-Bold="true">Select an activity agency to view more information.</asp:Label>
        <asp:GridView runat="server" ID="gvActivities" AutoGenerateColumns="false" OnSelectedIndexChanged="gvActivities_SelectedIndexChanged">
            <Columns>
                <asp:CommandField HeaderText="Select" ButtonType="Button" ShowSelectButton="true" />
                <asp:BoundField HeaderText="AgencyID" DataField="AgencyID" />
                <asp:BoundField HeaderText="City" DataField="City" />
                <asp:BoundField HeaderText="State" DataField="State" />
                <asp:BoundField HeaderText="Name" DataField="Name" />
                <asp:BoundField HeaderText="Address" DataField="Address" />
                <asp:BoundField HeaderText="Zip" DataField="Zip" />
            </Columns>
        </asp:GridView>

        <asp:Label runat="server" Visible="false" ID="lbldirection2" Font-Bold="true" Text="Select an Activity you want to book" />
        <asp:GridView runat="server" ID="gvActiviitesByAgencies" AutoGenerateColumns="false" OnSelectedIndexChanged="gvActiviitesByAgencies_SelectedIndexChanged">
            <Columns>
                <asp:CommandField HeaderText="Reserve" ButtonType="Button" ShowSelectButton="true" />
                <asp:BoundField HeaderText="ActivityID" DataField="ActivityID" />
                <asp:BoundField HeaderText="AgencyID" DataField="AgencyID" />
                <asp:BoundField HeaderText="VenueID" DataField="VenueID" />
                <asp:BoundField HeaderText="Name" DataField="Name" />
                <asp:BoundField HeaderText="Price" DataField="Price" />
                <asp:BoundField HeaderText="Type" DataField="Type" />
                <asp:BoundField HeaderText="StartDate" DataField="StartDate" />
                <asp:BoundField HeaderText="EndDate" DataField="EndDate" />
                <asp:BoundField HeaderText="MaxReserve" DataField="MaxReserve" />
                <asp:BoundField HeaderText="CurrrentReserve" DataField="CurrrentReserve" />
            </Columns>
        </asp:GridView>


        <%--    <asp:Button runat="server" ID="btnSearchActivitiesByVenue" Text="Search Activities by Venue"  OnClick="btnSearchActivitiesByVenue_Click"/>--%>
        <%--<asp:Button runat="server" ID="btnSearchActivitiesByAgency" Text="Search Activities by Agency" />
        <br />
        <asp:Label runat="server" ID="lblDirections4" Text="Enter search Criteria"></asp:Label>
        <br />
        <asp:Label runat="server" ID="lblActivityName" Text="Activity Name"></asp:Label>
        <asp:TextBox runat="server" ID="txtActivityName"></asp:TextBox>
        <asp:Label runat="server" ID="lblType" Text="Type"></asp:Label>
        <asp:TextBox runat="server" ID="txtType"></asp:TextBox>
        <asp:Label runat="server" ID="lblMaxPrice" Text="MaxPrice"></asp:Label>
        <asp:TextBox runat="server" ID="txtMaxPrice"></asp:TextBox>
        <br />
        <asp:Label runat="server" ID="lblStartDate" Text="Start Date"></asp:Label>
        <asp:TextBox runat="server" ID="txtStartDate" Enabled="false"></asp:TextBox>
        <asp:Label runat="server" ID="lblEndDate" Text="End Date"></asp:Label>
        <asp:TextBox runat="server" ID="txtEndDate" Enabled="false"></asp:TextBox>
        <br />
        <asp:Label runat="server" ID="lblCity2" Text="City"></asp:Label>
        <asp:TextBox runat="server" ID="txtCity"></asp:TextBox>
        <asp:Label runat="server" ID="lblState2" Text="State"></asp:Label>
        <asp:TextBox runat="server" ID="txtState"></asp:TextBox>
        <br />
        <asp:RadioButtonList runat="server" ID="rbdate" RepeatDirection="Vertical">
        <asp:ListItem Text="Start Date" Value="Start Date"></asp:ListItem>
         <asp:ListItem Text="End Date" Value="End Date"></asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Calendar runat="server" ID="calDate" OnSelectionChanged="calDate_SelectionChanged"></asp:Calendar>
        <br />
        <asp:Button runat="server" ID="btnSearch2" Text="Search" />
        --%>
    </form>
</body>
</html>
