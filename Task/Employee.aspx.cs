using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class Employee1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindEmployeeGrid();
            }
        }

        private void BindEmployeeGrid()
        {
            EmployeeGridView.DataSource = DataAccess.GetEmployees();
            EmployeeGridView.DataBind();
        }

        protected void EmployeeGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
           
        }

        protected void EmployeeGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = (int)EmployeeGridView.DataKeys[e.RowIndex].Value;
            DataAccess.DeleteEmployee(id);
            BindEmployeeGrid();
        }

    }
}