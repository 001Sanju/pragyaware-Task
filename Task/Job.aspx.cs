using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class Job1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindJobGrid();
            }
        }

        private void BindJobGrid()
        {
            JobGridView.DataSource = DataAccess.GetJobs();
            JobGridView.DataBind();
        }

        protected void JobGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
       
        }

        protected void JobGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = (int)JobGridView.DataKeys[e.RowIndex].Value;
            DataAccess.DeleteJob(id);
            BindJobGrid();
        }

    }
}