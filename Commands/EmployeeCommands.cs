using CQRS_Pattern.Models;
using CQRS_Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Pattern.Commands
{
    public class EmployeeCommands : IEmployeeCommands
    {
        private readonly IEmployeeCommandsRepository _commandsRepo;

        public EmployeeCommands(IEmployeeCommandsRepository commandsRepo)
        {
            _commandsRepo = commandsRepo;
        }
        public void SaveEmployeeData(Employee employee)
        {
            _commandsRepo.SaveEmployee(employee);
        }
    }
}
