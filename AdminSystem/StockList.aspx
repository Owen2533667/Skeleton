﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 495px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstGamesList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 388px; width: 422px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 442px; position: absolute" Text="Add" />
    </form>
</body>
</html>
