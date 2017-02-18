<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Description.aspx.cs" Inherits="TermProjectWS.Description" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="panel panel-default">
            <div class="panel-heading" style="text-align: center"><strong>Description Page</strong></div>
            <div class="panel-body">
                <asp:Button runat="server" ID="btnView" Text="View Test Page" OnClick="btnView_Click" />
                <br /><br /><br />
                <label runat="server"><strong>Methods</strong></label><br />
                <label runat="server">1. GetRentalCarAgencies</label><br />
                   <label runat="server">Accepts a city as a string ("Philadelphia") and state as a string ("PA). The dataset will return an AgencyName(string), AgencyID(int), city(string), and state(string)</label><br />
                <br />
                 <label runat="server">2. GetCarsByAgency</label><br />
                 <label runat="server">Accepts AgencyID as an int (123), city as a string ("Philadelphia") and state as a string ("PA). The dataset will return CarID(int), CarName(string), AgencyID(int), AgencyName(string), City(string), State(string)</label><br />
                <br />
                 <label runat="server">3. FindCars</label><br />
                <label runat="server">Accepts a requirements object, city as a string ("Philadelphia") and state as a string ("PA). The dataset will return CarID(int), CarName(string), AgencyID(int), AgencyName(string), City(string), State(string) but fits the requirements you entered in the requirements object.</label><br />
                <br />
                 <label runat="server">4. FindCarsByAgency</label><br />
                <label runat="server">Accepts a AgencyID(int), requirements object, city as a string ("Philadelphia") and state as a string ("PA). The dataset will return CarID(int), CarName(string), AgencyID(int), AgencyName(string), City(string), State(string) but fits the requirements you entered in the requirements object along with the specific agency.</label><br />
                  <br />
                 <label runat="server">5. Reserve</label><br />
                <label runat="server">Accepts an agency object, car object, customer object, travelsiteID(int), and travelSitePassword(string). This method updates the CarReservation table by adding AgencyName, AgencyID, CarName, CarID, CustomerID, CustomerName, and PhoneNumber.</label><br />
                      <br />
                 <label runat="server">6. FindCustomer</label><br />
                <label runat="server">Accepts a customer object, travelsiteID(int), and travelSitePassword(string). This dataset will return CustomerID, CustomerName, PhoneNumber, ShippingAddress, Password, TotalDollarSales, Vacation, CardNumber, ExpirationDate, and SecurityCode.</label><br />
                <br />
                  <label runat="server"><strong>Classes</strong></label><br />
                 <label runat="server">1. Agency</label><br />
                <label runat="server">Fields: Name(string), ID(int) Methods: Setters and Getters</label><br />
                  <label runat="server">2. Car</label><br />
                <label runat="server">Fields: Name(string), ID(int) Methods: Setters and Getters</label><br />
                <label runat="server">3. Customer</label><br />
                <label runat="server">Fields: Name(string), ID(int), PhoneNumber(string) Methods: Setters and Getters</label><br />
                    <label runat="server">4. Requirements</label><br />
                <label runat="server">Fields: fourDoors(bool), bool automatic(bool), SUV(bool), MPGInCity30(bool; this property determines if the car has 30mpg when driving in the city) Methods: Setters and Getters</label><br />
            </div>
        </div>
    </form>
</body>
</html>
