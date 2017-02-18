<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuyerPage.aspx.cs" Inherits="Project3.BuyerPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Buyer Page</title>
    <style type="text/css">
        .auto-style1 {
            width: 199px;
            height: 115px;
            position: absolute;
            top: 252px;
            left: 21px;
            z-index: 1;
        }

        .auto-style2 {
            position: absolute;
            top: 123px;
            left: 239px;
            z-index: 1;
        }

        .auto-style3 {
            position: absolute;
            top: 124px;
            left: 27px;
            z-index: 1;
        }

        .auto-style4 {
            position: absolute;
            top: 159px;
            left: 29px;
            z-index: 1;
        }

        .auto-style5 {
            position: absolute;
            top: 156px;
            left: 238px;
            z-index: 1;
        }

        .auto-style6 {
            position: absolute;
            top: 157px;
            left: 389px;
            z-index: 1;
            height: 24px;
            width: 71px;
        }

        .auto-style7 {
            position: absolute;
            top: 211px;
            left: 39px;
            z-index: 1;
        }
    </style>
</head>
<body style="background-color:cadetblue">
    <form id="form1" runat="server">

        <asp:GridView ID="gvTickets" runat="server" AutoGenerateColumns="False" CssClass="auto-style1" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
            <Columns>
                <asp:BoundField HeaderText="Event Name" DataField="EventName" />
                <asp:BoundField HeaderText="Event Type" DataField="EventType" />
                <asp:BoundField HeaderText="Event Date" DataField="EventDate" />
                <asp:BoundField HeaderText="Price" DataField="Price" />
                <asp:TemplateField HeaderText="Buy Ticket">
                    <ItemTemplate>
                        <asp:CheckBox ID="cbxBuyTicket" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
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

        <asp:DropDownList ID="ddlEventType" runat="server" AutoPostBack="true" CssClass="auto-style2" OnSelectedIndexChanged="ddlEventType_SelectedIndexChanged">
            <asp:ListItem Text="Sport" Value="Sport"></asp:ListItem>
            <asp:ListItem Text="Movie" Value="Movie"></asp:ListItem>
            <asp:ListItem Text="Theater" Value="Theater"></asp:ListItem>
            <asp:ListItem Text="Trade Show" Value="Trade Show"></asp:ListItem>
        </asp:DropDownList>

        <asp:Button ID="btnSearch" runat="server" CssClass="auto-style6" OnClick="btnSearch_Click" Text="Search" BackColor="#006699" BorderStyle="None" ForeColor="White" />
        <asp:Label ID="lblSearchEventType" runat="server" CssClass="auto-style3" Text="Search Tickets by Event Type:" ForeColor="White"></asp:Label>
        <asp:Label ID="lblSearchEventName" runat="server" CssClass="auto-style4" Text="Search Tickets by Event Name:" ForeColor="White"></asp:Label>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click1" style="z-index: 1; left: 405px; top: 403px; position: absolute; height: 51px; width: 115px;" Text="Submit" BackColor="#006600" ForeColor="White" />
        <asp:TextBox ID="txtSearchEventName" runat="server" CssClass="auto-style5"></asp:TextBox>

        <asp:Label ID="lblSucess" runat="server" CssClass="auto-style7" Text="You have sucessfully purchased a ticket!" ForeColor="White"></asp:Label>

        <p>

        <asp:Button ID="btnViewTickets" runat="server" OnClick="btnViewTickets_Click" Text="All Available Tickets" BackColor="#003366" BorderStyle="None" ForeColor="White" style="z-index: 1; left: 20px; top: 74px; position: absolute; height: 32px; width: 192px" />
        </p>
        <asp:Label ID="lblTitle" runat="server" Font-Size="X-Large" ForeColor="White" style="z-index: 1; left: 536px; top: 28px; position: absolute" Text="Buyer"></asp:Label>

    </form>
</body>
</html>
