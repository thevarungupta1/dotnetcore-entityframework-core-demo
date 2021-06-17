using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication31.Models;

namespace WebApplication31.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var data = _repository.GetAllEmployee();
            return Ok(data);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult Get(int id)
        {
            var data = _repository.GetEmployeeById(id);
            if (data == null)
                return NotFound("No Record found with id: " + id);
            return Ok(data);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post(Employee employee)
        {
            var data = _repository.AddEmployee(employee);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + 
                HttpContext.Request.Path + "/" + employee.Id, employee);
        }
    }
}
