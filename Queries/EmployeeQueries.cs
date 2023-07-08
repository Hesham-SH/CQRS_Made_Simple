using CQRS_Pattern.DTOs;
using CQRS_Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Pattern.Queries
{
    public class EmployeeQueries : IEmployeeQueries
    {
        private readonly IEmployeeQueriesRepository _queriesRepo;

        public EmployeeQueries(IEmployeeQueriesRepository queriesRepo)
        {
            _queriesRepo = queriesRepo;
        }

        public EmployeeDTO FindById(int employeeId)
        {
            var emp = _queriesRepo.GetById(employeeId);
            return new EmployeeDTO
            {
                Id = emp.Id,
                FullName = emp.FirstName + " " + emp.LastName,
                Address = emp.Street + " " + emp.City + " " + emp.PostalCode,
                Age = Convert.ToInt32(Math.Abs(((DateTime.Now - emp.DateOfBirth).TotalDays) / 365)) - 1
            };
        }
    }
}
