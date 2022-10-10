using API_Training_WFM.Abstractions;
using API_Training_WFM.Helper;
using API_Training_WFM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API_Training_WFM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _EmployeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            _EmployeesService = employeesService;
        }

        [Authorize]
        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult GetEmployees()
        {
            try
            {
                var result = _EmployeesService.GetAllEmployees();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Exception occurred " + ex.Message.ToString());
            }
        }

        [Authorize]
        [HttpPut]
        [Route("UpdateEmployees")]
        public IActionResult UpdateEmployees(Employees employee)
        {
            try
            {
                var result = _EmployeesService.UpdateEmployee(employee);
                if(result)
                    return new JsonResult(new { message = "Updated Successfully" }) { StatusCode = StatusCodes.Status200OK };
                else
                    return new JsonResult(new { message = "No record Found" }) { StatusCode = StatusCodes.Status204NoContent };

            }
            catch (Exception ex)
            {
                return BadRequest("Exception occurred "+ ex.Message.ToString());
            }
        }
    }
}
