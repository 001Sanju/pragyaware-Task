using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EmployeeId { get; set; } 
    }

}