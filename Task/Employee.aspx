<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Task.Employee1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <asp:GridView ID="EmployeeGridView" runat="server" AutoGenerateColumns="False" OnRowEditing="EmployeeGridView_RowEditing" OnRowDeleting="EmployeeGridView_RowDeleting">
    <Columns>
        <asp:BoundField DataField="Id" HeaderText="ID" />
        <asp:BoundField DataField="FirstName" HeaderText="First Name" />
        <asp:BoundField DataField="LastName" HeaderText="Last Name" />
        <asp:BoundField DataField="Email" HeaderText="Email" />
        <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
    </Columns>
</asp:GridView>
<asp:LinkButton ID="AddEmployeeButton" runat="server" Text="Add New Employee" PostBackUrl="~/AddEmployee.aspx" />

    </form>
</body>
</html>
