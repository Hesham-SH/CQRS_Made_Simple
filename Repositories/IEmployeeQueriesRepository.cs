using CQRS_Pattern.DTOs;
using CQRS_Pattern.Models;

namespace CQRS_Pattern.Repositories
{
    public interface IEmployeeQueriesRepository
    {
        Employee GetById(int employeeId);
    }
}
