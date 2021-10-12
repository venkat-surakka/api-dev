using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using api_practice.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace api_practice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        IList<Employee>
            employees =
                new List<Employee>()
                {
                    new Employee()
                    {
                        EmployeeId = 1,
                        EmployeeName = "Venkat Surakka",
                        Address = "Ponsonby",
                        Department = "IT"
                    },
                    new Employee()
                    {
                        EmployeeId = 2,
                        EmployeeName = "Soujanya Surakka",
                        Address = "Hobsonville Point",
                        Department = "HR"
                    },
                    new Employee()
                    {
                        EmployeeId = 3,
                        EmployeeName = "Shreyas Surakka",
                        Address = "HP Secoundary School",
                        Department = "IT"
                    },
                    new Employee()
                    {
                        EmployeeId = 4,
                        EmployeeName = "Vijval Surakka",
                        Address = "HP Primary School",
                        Department = "Sales"
                    }
                };

        /// <summary>
        /// Get the list of all employees
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employees);
        }

        /// <summary>
        /// Get the details of a single employee
        /// </summary>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //Return a single employee detail

            var employee = employees.FirstOrDefault(e => e.EmployeeId == id);
            if (employee == null)
            {
                // return NotFound();
                return Ok(employees.FirstOrDefault(e => e.EmployeeId == 1));
            }
            return Ok(employee);
        }
    }
}
