<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="Task.AddEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="FirstNameTextBox" runat="server" placeholder="First Name" />
        <asp:TextBox ID="LastNameTextBox" runat="server" placeholder="Last Name" />
        <asp:TextBox ID="EmailTextBox" runat="server" placeholder="Email" />
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />

    </form>
</body>
</html>
