<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="TermProjectWS.TestPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="panel panel-default">
            <div class="panel-heading" style="text-align: center"><strong>Test Page</strong></div>
            <div class="panel-body">
                <asp:Button runat="server" ID="btnView" Text="View Description Page" OnClick="btnView_Click" />
                <br /><br /><br />
                <asp:Label runat="server">This method returns a list of car agency names and their IDs when the user inputs a city and state</asp:Label>
                <br />
                <asp:GridView runat="server" ID="gvCarAgency" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField HeaderText="City" DataField="City" />
                        <asp:BoundField HeaderText="State" DataField="State" />
                        <asp:BoundField HeaderText="Car Agency" DataField="AgencyName" />
                        <asp:BoundField HeaderText="Agency ID" DataField="AgencyID" />
                    </Columns>
                </asp:GridView>
                <asp:Button runat="server" Text="Submit" ID="btnSubmit1" OnClick="btnSubmit1_Click" />
                <br />
                <br />
                <asp:Label runat="server">This method returns a list of cars available from a specific rental agency when inputs an Agency ID, city, and state</asp:Label>
                <asp:GridView runat="server" ID="gvCars" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField HeaderText="City" DataField="City" />
                        <asp:BoundField HeaderText="State" DataField="State" />
                        <asp:BoundField HeaderText="Car Agency" DataField="AgencyName" />
                        <asp:BoundField HeaderText="Agency ID" DataField="AgencyID" />
                        <asp:BoundField HeaderText="CarID" DataField="CarID" />
                        <asp:BoundField HeaderText="CarName" DataField="CarName" />
                    </Columns>
                </asp:GridView>
                <asp:Button runat="server" Text="Submit" ID="btnSubmit2" OnClick="btnSubmit2_Click" />
                <br />
                <br />
                <asp:Label runat="server">This method returns a list of cars that fits the inputted requirements</asp:Label>
                <asp:GridView runat="server" ID="gvCarReqs" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField HeaderText="City" DataField="City" />
                        <asp:BoundField HeaderText="State" DataField="State" />
                        <asp:BoundField HeaderText="Car Agency" DataField="AgencyName" />
                        <asp:BoundField HeaderText="Agency ID" DataField="AgencyID" />
                        <asp:BoundField HeaderText="CarID" DataField="CarID" />
                        <asp:BoundField HeaderText="CarName" DataField="CarName" />
                    </Columns>
                </asp:GridView>
                <asp:Button runat="server" Text="Submit" ID="btnSubmit3" OnClick="btnSubmit3_Click" />
                <br />
                <br />
                <asp:Label runat="server">This method returns a list of cars that fits the car requirements and by car agency</asp:Label>
                <asp:GridView runat="server" ID="gvCarReqsAgency" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField HeaderText="City" DataField="City" />
                        <asp:BoundField HeaderText="State" DataField="State" />
                        <asp:BoundField HeaderText="Car Agency" DataField="AgencyName" />
                        <asp:BoundField HeaderText="Agency ID" DataField="AgencyID" />
                        <asp:BoundField HeaderText="CarID" DataField="CarID" />
                        <asp:BoundField HeaderText="CarName" DataField="CarName" />
                    </Columns>
                </asp:GridView>
                <asp:Button runat="server" Text="Submit" ID="btnSubmit4" OnClick="btnSubmit4_Click" />
                <br />
                <br />
                <asp:Label runat="server">This method adds a customer to the reservation table along with car and agency details</asp:Label><br />
                <asp:Label runat="server" ID="lblText"></asp:Label><br />
                <asp:Button runat="server" ID="btnReserve" Text="Reserve" OnClick="btnReserve_Click" />
                <br />
                <br />
                <asp:Label runat="server">This method returns a customer that matches the customer requirement</asp:Label>
                <asp:GridView runat="server" ID="gvCustomer" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="CustomerID" />
                        <asp:BoundField HeaderText="Name" DataField="CustomerName" />
                        <asp:BoundField HeaderText="Phone Number" DataField="PhoneNumber" />
                    </Columns>
                </asp:GridView>
                <asp:Button runat="server" ID="btnFindCustomers" Text="Find Customer" OnClick="btnFindCustomers_Click" />
            </div>
        </div>
    </form>
</body>
</html>
