<!DOCTYPE html>
<html>
<head runat="server">
    <title>Asp Dot net Developer Task Activity</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
      
            <asp:Menu ID="MainMenu" runat="server">
                <Items>
                    <asp:MenuItem Text="Home" NavigateUrl="~/Employees.aspx" />
                    <asp:MenuItem Text="Add Employee" NavigateUrl="~/AddEmployee.aspx" />
                    <asp:MenuItem Text="Add Job" NavigateUrl="~/AddJob.aspx" />
                    <asp:MenuItem Text="View Employees" NavigateUrl="~/Employees.aspx" />
                    <asp:MenuItem Text="View Jobs" NavigateUrl="~/Jobs.aspx" />
                </Items>
            </asp:Menu>
           
        </div>
    </form>
</body>
</html>
