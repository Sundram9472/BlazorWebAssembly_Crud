using BlazorWebAssembly_Crud.Server.DBContext;
using BlazorWebAssembly_Crud.Server.Services;
using BlazorWebAssembly_Crud.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebAssembly_Crud.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeMangeController : ControllerBase
    {
        private readonly IEmployeeManager _employee;
        private readonly ILogger<EmployeeMangeController> _logger;

        public EmployeeMangeController(IEmployeeManager employee, ILogger<EmployeeMangeController> logger)
        {
            _employee = employee;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
           return _employee.GetEmpDetails();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Employee user = _employee.GetEmpData(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        [HttpPost]
        public void Post(Employee user)
        {
            _employee.AddEmp(user);
        }

        [HttpPut]
        public void Put(Employee user)
        {
            _employee.UpdateEmpDetails(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _employee.DeleteEmp(id);
            return Ok();
        }


    }
}
