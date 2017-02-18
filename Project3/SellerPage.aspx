<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SellerPage.aspx.cs" Inherits="Project3.SellerPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 73px;
            left: 23px;
        }
        .auto-style2 {
            position: absolute;
            top: 175px;
            left: 221px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 232px;
            left: 18px;
            z-index: 1;
            right: 1087px;
        }
        .auto-style4 {
            position: absolute;
            top: 231px;
            left: 131px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 231px;
            left: 360px;
            z-index: 1;
            right: 720px;
        }
        .auto-style6 {
            position: absolute;
            top: 236px;
            left: 451px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 270px;
            left: 18px;
            z-index: 1;
        }
        .auto-style8 {
            height: 541px;
        }
        .auto-style11 {
            position: absolute;
            top: 319px;
            left: 360px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 318px;
            left: 417px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 392px;
            left: 347px;
            z-index: 1;
            height: 48px;
            width: 132px;
        }
        .auto-style14 {
            position: absolute;
            top: 142px;
            left: 151px;
            z-index: 1;
            right: 805px;
        }
        .auto-style15 {
            width: 199px;
            height: 115px;
            position: absolute;
            top: 169px;
            left: 16px;
            z-index: 1;
        }
    </style>
</head>
<body style="background-color:cadetblue">
    <form id="form1" runat="server" class="auto-style8">

        <asp:Button ID="btnSellTicket" runat="server" CssClass="auto-style1" style="z-index: 1; height: 33px; width: 109px;" Text="Sell Ticket" OnClick="btnSellTicket_Click" BackColor="#006699" BorderStyle="None" ForeColor="White" />
        <asp:Label ID="lblEventInformation" runat="server" CssClass="auto-style2" Text="Event Information" ForeColor="White"></asp:Label>
        <asp:Label ID="lblEventName" runat="server" CssClass="auto-style3" Text="Event Name:" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtEventName" runat="server" CssClass="auto-style4"></asp:TextBox>
        <asp:Label ID="lblEventType" runat="server" CssClass="auto-style5" Text="Event Type:" ForeColor="White"></asp:Label>
        <asp:DropDownList ID="ddlEventType" runat="server" CssClass="auto-style6">
            <asp:ListItem Text="Sport" Value="Sport"></asp:ListItem>
            <asp:ListItem Text="Concert" Value="Conert"></asp:ListItem>
            <asp:ListItem Text="Movie" Value="Movie"></asp:ListItem>
            <asp:ListItem Text="Trade Show" Value="Trade Show"></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblEventDate" runat="server" CssClass="auto-style7" Text="Event Date:" ForeColor="White"></asp:Label>
      
    
        <asp:Button ID="btnViewTickets" runat="server" Text="Show My Tickets" OnClick="btnViewTickets_Click" BackColor="#66CCFF" BorderStyle="None" ForeColor="White" style="z-index: 1; left: 158px; top: 74px; position: absolute; height: 30px; width: 171px" />
      
    
        <br />
        <asp:Label ID="lblTitle" runat="server" Font-Size="X-Large" ForeColor="White" style="z-index: 1; left: 558px; top: 35px; position: absolute" Text="Seller"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblSucess" runat="server" CssClass="auto-style14" Text="You have successfully added a ticket!" ForeColor="White"></asp:Label>
        <br />
        <asp:Button ID="btnSubmit" runat="server" CssClass="auto-style13" OnClick="btnSubmit_Click" Text="Submit" BackColor="#006600" BorderStyle="None" ForeColor="White" />
        <br />
        <asp:GridView ID="gvTickets" runat="server" AutoGenerateColumns="False" CssClass="auto-style15" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" >
            <Columns>
                <asp:BoundField HeaderText="Event Name" DataField="EventName" />
                <asp:BoundField HeaderText="Event Type" DataField="EventType" />
                <asp:BoundField HeaderText="Event Date" DataField="EventDate" />
                <asp:BoundField HeaderText="Price" DataField="Price" />
                <asp:BoundField HeaderText="Sold" DataField="Sold" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>

        <asp:Calendar ID="eventCalendar" runat="server" style="z-index: 1; left: 34px; top: 311px; position: absolute; height: 188px; width: 259px" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
            <NextPrevStyle VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#808080" />
            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" />
            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
            <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>

      
        
        <asp:TextBox ID="txtPrice" runat="server" CssClass="auto-style12"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" CssClass="auto-style11" Text="Price:" ForeColor="White"></asp:Label>

      
    </form>
</body>
</html>
