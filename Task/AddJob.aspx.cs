using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class AddJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string description = DescriptionTextBox.Text;

            DateTime startDate;
            bool isStartDateValid = DateTime.TryParse(StartDateTextBox.Text, out startDate);
            if (!isStartDateValid)
            {
                ErrorMessage.Text = "Invalid Start Date format. Please use MM/dd/yyyy.";
                return;
            }

            DateTime endDate;
            bool isEndDateValid = DateTime.TryParse(EndDateTextBox.Text, out endDate);
            if (!isEndDateValid)
            {
                ErrorMessage.Text = "Invalid End Date format. Please use MM/dd/yyyy.";
                return;
            }

            int employeeId;
            bool isEmployeeIdValid = int.TryParse(EmployeeIdTextBox.Text, out employeeId);
            if (!isEmployeeIdValid)
            {
                ErrorMessage.Text = "Invalid Employee ID format. It should be a number.";
                return;
            }

            // Check if the employee ID is valid
            Employee employee = DataAccess.GetEmployeeById(employeeId);
            if (employee == null)
            {
                ErrorMessage.Text = "Employee ID not found.";
                return;
            }

            // Add the new job to your data store
            DataAccess.AddJob(new Job { Title = title, Description = description, StartDate = startDate, EndDate = endDate, EmployeeId = employeeId });

            // Redirect to Jobs page or another confirmation page
            Response.Redirect("Jobs.aspx");
        }
    }
}