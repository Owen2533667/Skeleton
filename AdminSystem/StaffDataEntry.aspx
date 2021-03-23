<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>



<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title></title>

</head>

<body>

    <form id="form1" runat="server">

        <div>

        </div>

        <p>

            <asp:Label ID="lblStaffNO" runat="server" Text="Staff Number" Height="16px" width="95px"></asp:Label>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="txtBoxStaffNumber" runat="server" height="22px" width="128px"></asp:TextBox>

        </p>

        <p>

            <asp:Label ID="StaffName" runat="server" Text="Name" width="41px"></asp:Label>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="txtBoxName" runat="server" height="22px" width="128px"></asp:TextBox>

        </p>

        <p>

            <asp:Label ID="lblAddress" runat="server" Text="Address" width="41px"></asp:Label>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="txtBoxAddress" runat="server" height="22px" width="128px"></asp:TextBox>

        </p>

        <asp:Label ID="lblGender" runat="server" Text="Gender" width="41px"></asp:Label>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:TextBox ID="txtBoxGender" runat="server" height="22px" width="128px"></asp:TextBox>

        <p>

            <asp:Label ID="lblSalary" runat="server" Height="16px" Text="Salary" width="41px"></asp:Label>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="txtBoxSalary" runat="server" height="22px" width="128px"></asp:TextBox>

        </p>

        <asp:Label ID="lblEmploymentDate" runat="server" Height="24px" Text="Employment Date" width="118px"></asp:Label>

        <asp:TextBox ID="txtBoxEmploymentDate" runat="server" height="22px" width="128px"></asp:TextBox>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <p>

            <asp:Label ID="lblDOB" runat="server" Text="D.O.B" width="41px"></asp:Label>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="txtBoxDOB" runat="server"></asp:TextBox>

        </p>

        <p>

            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="29px" />

&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />

        </p>

        <p>

            &nbsp;</p>

    </form>

</body>

</html>

