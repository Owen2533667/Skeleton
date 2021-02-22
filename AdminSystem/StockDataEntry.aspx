<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 306px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblGameId" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Game ID" width="109px"></asp:Label>
            <asp:TextBox ID="txtGameId" runat="server" style="z-index: 1; left: 128px; top: 8px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblGameTitle" runat="server" style="z-index: 1; left: 10px; top: 36px; position: absolute" Text="Game Title"></asp:Label>
        <asp:TextBox ID="txtGameTitle" runat="server" style="z-index: 1; left: 128px; top: 34px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="lblGameDescription" runat="server" style="z-index: 1; left: 10px; top: 59px; position: absolute" Text="Game Description"></asp:Label>
        <asp:TextBox ID="txtGameDescription" runat="server" style="z-index: 1; left: 128px; top: 57px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblReleaseDate" runat="server" EnableTheming="True" style="z-index: 1; left: 11px; top: 84px; position: absolute" Text="Release Date" width="109px"></asp:Label>
        <p>
            <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 128px; top: 82px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 11px; top: 107px; position: absolute" Text="Price" width="109px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 128px; top: 106px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtStockQuantity" runat="server" style="z-index: 1; top: 131px; position: absolute; left: 128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblStockQuantity" runat="server" style="z-index: 1; left: 11px; top: 132px; position: absolute" Text="Stock Quantity" width="109px"></asp:Label>
        <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 10px; top: 166px; position: absolute" Text="In Stock" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 203px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 10px; top: 238px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 50px; top: 238px; position: absolute" Text="Cancel" />
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 265px; top: 8px; position: absolute" Text="Find" />
        </p>
    </form>
</body>
</html>
