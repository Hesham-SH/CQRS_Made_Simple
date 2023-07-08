using CQRS_Pattern.DTOs;
using CQRS_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Pattern.Repositories
{
    internal class EmployeeQueriesRepository : IEmployeeQueriesRepository
    {
        public Employee GetById(int employeeId)
        {
            //Get The Employee From The Data Source
            //Returning a Mock User To Simulate The Real World Scenario
            return new Employee()
            {
                Id = 100,
                FirstName = "Brian",
                LastName = "Kernighan",
                DateOfBirth = new DateTime(1970, 8, 12),
                Street = "63 A Seventh Stage",
                City = "Ismailia",
                PostalCode = "41512"
            };
        }
    }
}
