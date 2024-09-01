using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task
{
    using System.Collections.Generic;
    using System.Linq;

    public static class DataAccess
    {
        private static List<Employee> employees = new List<Employee>();
        private static List<Job> jobs = new List<Job>();

       
        public static List<Employee> GetEmployees() => employees;

        public static void AddEmployee(Employee employee)
        {
            employee.Id = employees.Count > 0 ? employees.Max(e => e.Id) + 1 : 1;
            employees.Add(employee);
        }

        public static void UpdateEmployee(Employee employee)
        {
            var existingEmployee = employees.FirstOrDefault(e => e.Id == employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.Email = employee.Email;
            }
        }

        public static void DeleteEmployee(int id) => employees.RemoveAll(e => e.Id == id);

        public static Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }
        public static List<Job> GetJobs() => jobs;

        public static void AddJob(Job job)
        {
            job.Id = jobs.Count > 0 ? jobs.Max(j => j.Id) + 1 : 1;
            jobs.Add(job);
        }

        public static void UpdateJob(Job job)
        {
            var existingJob = jobs.FirstOrDefault(j => j.Id == job.Id);
            if (existingJob != null)
            {
                existingJob.Title = job.Title;
                existingJob.Description = job.Description;
                existingJob.StartDate = job.StartDate;
                existingJob.EndDate = job.EndDate;
                existingJob.EmployeeId = job.EmployeeId;
            }
        }

        public static void DeleteJob(int id) => jobs.RemoveAll(j => j.Id == id);
    }

}