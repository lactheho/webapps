<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="Project1.Quiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 1012px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-position: left center; background-image: url('Resources/kanye.jpg')">
    <div>
    
    </div>
        <asp:Label ID="lblTitle" runat="server" Text="Your Results" Font-Bold="True" Font-Size="X-Large" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion1" runat="server" style="z-index: 1; left: 15px; top: 75px; position: absolute; bottom: 570px;" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion2" runat="server" style="z-index: 1; left: 14px; top: 114px; position: absolute; bottom: 527px;" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion3" runat="server" style="z-index: 1; left: 13px; top: 152px; position: absolute; bottom: 484px;" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion4" runat="server" style="z-index: 1; left: 14px; top: 189px; position: absolute; height: 19px" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion5" runat="server" style="z-index: 1; left: 13px; top: 225px; position: absolute; bottom: 412px;" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion6" runat="server" style="z-index: 1; left: 12px; top: 263px; position: absolute; bottom: 382px;" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion7" runat="server" style="z-index: 1; left: 13px; top: 297px; position: absolute" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion8" runat="server" style="z-index: 1; left: 11px; top: 332px; position: absolute; bottom: 341px;" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion9" runat="server" style="z-index: 1; left: 11px; top: 368px; position: absolute" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion10" runat="server" style="z-index: 1; left: 11px; top: 404px; position: absolute" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion11" runat="server" style="z-index: 1; left: 13px; top: 439px; position: absolute; height: 19px" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion12" runat="server" style="z-index: 1; left: 13px; top: 475px; position: absolute" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion13" runat="server" style="z-index: 1; left: 14px; top: 511px; position: absolute" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion14" runat="server" style="z-index: 1; left: 13px; top: 547px; position: absolute" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblQuestion15" runat="server" style="z-index: 1; left: 13px; top: 586px; position: absolute" Text="Label" ForeColor="White"></asp:Label>
        <asp:Label ID="lblScore" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 13px; top: 622px; position: absolute" Text="Label" ForeColor="White"></asp:Label>
    </form>
    </body>
</html>
