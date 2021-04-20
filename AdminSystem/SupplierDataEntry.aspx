<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="SupplierNoproperty" runat="server" Text="Supply Number"></asp:Label>
            <asp:TextBox ID="txtSupplierNumber" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="SupplierName" runat="server" Text="Supplier Name"></asp:Label>
&nbsp;<asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Description" runat="server" Text="Supplier Description"></asp:Label>
            <asp:TextBox ID="txtSupplierDescription" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="ReleaseDate" runat="server" Text="Release Date"></asp:Label>
        <asp:TextBox ID="txtReleaseDate" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Price" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="StockQuantity" runat="server" Text="Stock Quantity"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="InQuantity" runat="server" Text="In Stock"></asp:Label>
            <asp:TextBox ID="txtInstock" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="lblError"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <p>
            <asp:Button ID="btnCancel" runat="server" Height="24px" OnClick="Button2_Click" Text="Cancel" Width="60px" />
        </p>
    </form>
</body>
</html>
