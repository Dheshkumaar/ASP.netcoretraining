using API_Training_WFM.Models;
using System.Collections.Generic;

namespace API_Training_WFM.Abstractions
{
    public interface IEmployeesService
    {
        IEnumerable<EmployeewithSkills> GetAllEmployees();
        bool UpdateEmployee(Employees employees);
        Employees GetEmployeebyId(int id);
    }
}
