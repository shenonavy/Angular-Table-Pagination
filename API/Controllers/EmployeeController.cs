using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using API.SeedData;
using System.Linq;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("getEmployee")]
        public ActionResult<IEnumerable<Employee>> GetAll([FromQuery] int perPage, int page)
        {
            int fromRows = 0;
            fromRows = ((page - 1) * perPage);
            var employees = Seeds.LoadData().Skip(fromRows).Take(perPage).ToList();
            return employees;
        }
        [HttpGet("getTotalRecord")]
        public ActionResult<int> TotalRecord()
        {
            var employees = Seeds.LoadData().ToList();
            return employees.Count();
        }
    }
}