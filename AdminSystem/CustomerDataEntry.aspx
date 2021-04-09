<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 7px">
    <form id="form1" runat="server">
        <div style="height: 314px">
            <br />
            <asp:Label ID="lblCustomerNumber" runat="server" Text="Customer Number"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerNumber" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerName" runat="server" Text="Name" width="113px"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerEmail" runat="server" Text="Email" width="113px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerDOB" runat="server" Text="DOB" width="113px"></asp:Label>
            <asp:TextBox ID="txtCustomerDOB" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerGender" runat="server" Text="Gender" width="113px"></asp:Label>
            <asp:TextBox ID="txtCustomerGender" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerPostcode" runat="server" Text="Postcode" width="113px"></asp:Label>
            <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
