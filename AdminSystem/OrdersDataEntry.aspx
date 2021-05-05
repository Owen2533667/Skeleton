<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 539px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderNo" runat="server" Text="OrderNo" width="121px"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server" style="margin-left: 15px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" style="margin-left: 17px" Width="49px" />

        <br />
        <asp:Label ID="lblItemDescription" runat="server" Text="Item Description"></asp:Label>
        <asp:TextBox ID="txtItemDescription" runat="server" style="margin-left: 36px" Width="120px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDeliveryAddress" runat="server" Text="Delivery Address" width="121px"></asp:Label>
        <asp:TextBox ID="txtDeliveryAddress" runat="server" style="margin-left: 15px" ></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderPlaced" runat="server" Text="Order Placed" width="121px"></asp:Label>
        <asp:TextBox ID="txtOrderPlaced" runat="server" style="margin-left: 15px" ></asp:TextBox>
        <br />
        <asp:Label ID="lblItemPrice" runat="server" Text="Item Price" width="121px"></asp:Label>
        <asp:TextBox ID="txtItemPrice" runat="server" style="margin-left: 15px"></asp:TextBox>
        <br />
        <asp:Label ID="lblItemColour" runat="server" Text="Item Colour" width="121px"></asp:Label>
        <asp:TextBox ID="txtItemColour" runat="server" style="margin-left: 15px"></asp:TextBox>
        <br />
         <asp:Label ID="lblStaffId" runat="server" Text="StaffId" width="121px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="margin-left: 15px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkItemAvailability" runat="server" Text="ItemAvailability" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click"/>&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>

