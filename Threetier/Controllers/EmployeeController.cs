using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Threetier_DataAccessLayer.Repository.Entities;

namespace Threetier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private Threetier_BusinessLogicLayer.EmployeeBLL _BLL;

        public EmployeeController()
        {
            _BLL = new Threetier_BusinessLogicLayer.EmployeeBLL();
        }


        [HttpGet]
        [Route("GetEmployees")]

        public IActionResult GetEmployee()
        {
            var list =_BLL.GetALlEmployees();
            return Ok(list);
        }


        [HttpPost]
        [Route("Add")]

        public IActionResult AddEmployee(Employee e)
        {
            _BLL.AddEmployees(e);
            return Ok();
        }
    }
}
