﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LandingForm.aspx.cs" Inherits="HotSeatBooking.Controllers.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            margin-left: 90px;
            margin-top: 100px;
        }
    </style>
</head>
<body style="height: 667px; background-color: #C0C0C0;">
    <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Controllers/BookingForm.aspx">Book a seat</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Controllers/ReportingPage.html">Search for employee</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
        <p>
            <asp:Image ID="Image1" runat="server" Height="315px" ImageUrl="~/Content/Image/OfficeFloorLayout.JPG" Width="573px" />
        </p>
    </form>
</body>
</html>
