<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJob.aspx.cs" Inherits="Task.AddJob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TitleTextBox" runat="server" placeholder="Job Title" />
        <asp:TextBox ID="DescriptionTextBox" runat="server" placeholder="Job Description" />
        <asp:TextBox ID="StartDateTextBox" runat="server" placeholder="Start Date" />
        <asp:TextBox ID="EndDateTextBox" runat="server" placeholder="End Date" />
        <asp:TextBox ID="EmployeeIdTextBox" runat="server" placeholder="Employee ID" />
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        <asp:Label ID="ErrorMessage" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
