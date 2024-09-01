<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Job.aspx.cs" Inherits="Task.Job1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <asp:GridView ID="JobGridView" runat="server" AutoGenerateColumns="False" OnRowEditing="JobGridView_RowEditing" OnRowDeleting="JobGridView_RowDeleting">
    <Columns>
        <asp:BoundField DataField="Id" HeaderText="ID" />
        <asp:BoundField DataField="Title" HeaderText="Title" />
        <asp:BoundField DataField="Description" HeaderText="Description" />
        <asp:BoundField DataField="StartDate" HeaderText="Start Date" />
        <asp:BoundField DataField="EndDate" HeaderText="End Date" />
        <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
    </Columns>
</asp:GridView>
<asp:LinkButton ID="AddJobButton" runat="server" Text="Add New Job" PostBackUrl="~/AddJob.aspx" />

    </form>
</body>
</html>
