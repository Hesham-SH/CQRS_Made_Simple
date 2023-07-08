using CQRS_Pattern.Models;

namespace CQRS_Pattern.Repositories
{
    public class EmployeeCommandsRepository : IEmployeeCommandsRepository
    {
        public void SaveEmployee(Employee emp)
        {
            //Save The Changes Made To The Employee
            throw new NotImplementedException();
        }
    }
}
