using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using api_practice.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace api_practice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OxygenCylindersController : ControllerBase
    {
        IList<OxygenCylinder>
            oxygenCylinders =
                new List<OxygenCylinder>()
                {
                    new OxygenCylinder()
                    {
                        Id = 101,
                        Brand = "EverFlo",
                        Capacity = 14,
                        Price = 59000
                    },
                    new OxygenCylinder()
                    {
                        Id = 102,
                        Braand = "SimplyGo Mini",
                        Capacity = 2.7,
                        Price = 280651
                    },
                    new OxygenCylinder()
                    {
                        Id = 103,
                        Brand = "SimplyGo",
                        Capacity = 4.5,
                        Price = 172300
                    }
                };

        /// <summary>
        /// Get the list of all Oxygen Cylinders
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(oxygenCylinders);
        }

        /// <summary>
        /// Get the details of a single Oxygen Cylinder
        /// </summary>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var oxygenCylinder = oxygenCylinders.FirstOrDefault(c => c.Id == id);
            if (oxygenCylinder == null)
            {
                return NotFound();
            }

            return Ok(oxygenCylinder);
        }
    }
}
