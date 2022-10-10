using API_Training_WFM.Abstractions;
using API_Training_WFM.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_Training_WFM.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly WFMDbContext _wfmDbContext;
        public EmployeesService(WFMDbContext wfmDbContext)
        {
            _wfmDbContext = wfmDbContext;
        }
        public IEnumerable<EmployeewithSkills> GetAllEmployees()
        {
            var result = _wfmDbContext.Employees.Where(x => x.lockstatus == "not_requested").Select(x => new EmployeewithSkills
            {
                employee_id = x.employee_id,
                employee_name = x.employee_name,
                status = x.status,
                manager = x.manager,
                wfm_manager = x.wfm_manager,
                email = x.email,
                experience = x.experience,
                lockstatus = x.lockstatus,
                Profilename = x.profile.profile_name,
                Skills = x.Skillmaps.Select(y => y.skills.skillname).ToList()
            }).ToList();

            return result;
        }

        public Employees GetEmployeebyId(int id)
        {
            var emp = _wfmDbContext.Employees.Where(x => x.employee_id == id).FirstOrDefault();
            return emp;
        }

        public bool UpdateEmployee(Employees employees)
        {
            var emp = GetEmployeebyId(employees.employee_id);
            if (emp != null)
            {
                emp.employee_id = employees.employee_id;
                emp.lockstatus= employees.lockstatus;
                _wfmDbContext.Update(emp);
                _wfmDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
