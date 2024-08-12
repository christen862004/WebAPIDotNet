using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDotNet.DTO;
using WebAPIDotNet.Models;

namespace WebAPIDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ITIContext context;

        public EmployeeController(ITIContext context)
        {
            this.context = context;
        }
        [HttpGet("{id:int}")]
        public ActionResult<GeneralResponse> Get(int id)
        {
            Employee emp= context.Employee.FirstOrDefault(x => x.Id == id);
            GeneralResponse generalResponse = new GeneralResponse();
            if(emp != null) { 
            //syccess
                generalResponse.IsSuccess = true;
                generalResponse.Data = emp;

            }
            else
            {
                generalResponse.IsSuccess = false;
                generalResponse.Data = "Id In Valid";
            }
            //fail
            //return Ok(generalResponse);
            return generalResponse;
        }
        [HttpPost]
        public IActionResult addEmp(Employee emp)
        {
            //if (ModelState.IsValid)
            //{

            //}
            return Ok(emp);
        }

    }
}
