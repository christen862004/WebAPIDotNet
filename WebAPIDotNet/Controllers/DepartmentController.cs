using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDotNet.Models;

namespace WebAPIDotNet.Controllers
{
    [Route("api/[controller]")]//api/DEpartment
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        ITIContext context;
        public DepartmentController( ITIContext _Context)
        {
            context = _Context;
        }
        //api/department verb get
        [HttpGet]
        public IActionResult DisplayAllDept()
        {
            List<Department> deptlist =
                context.Department.ToList();
            return Ok(deptlist);
        }
      
        [HttpGet]
        [Route("{id:int}")]//api/departmemtn/1
        public IActionResult GetByID(int id)
        {
            Department dept =
                context.Department.FirstOrDefault(d=>d.Id==id);
            return Ok(dept);
        }

        [HttpGet("{name:alpha}")]//api/department/{name}
        public IActionResult GetByName(string name)
        {
            Department dept =
               context.Department.FirstOrDefault(d => d.Name == name);
            return Ok(dept);
        }



        //api/department Post
        [HttpPost]
        public IActionResult AddDept(Department dept)
        {
            context.Department.Add(dept);
            context.SaveChanges();
            // return Created($"http://localhost:22013/api/Deaprtment/{dept.Id}",dept);
            return CreatedAtAction("GetByID",new { id=dept.Id}, dept);
        }
        //api/Department 
        [HttpPut("{id:int}")]
        public IActionResult UpdateDept(int id,Department deptFromREquest)
        {
            Department deptFromDB=
                context.Department.FirstOrDefault(d => d.Id == id);
            if (deptFromDB != null)
            {
                deptFromDB.Name = deptFromREquest.Name;
                deptFromDB.ManagerName = deptFromREquest.ManagerName;
                context.SaveChanges();
                return NoContent();
            }
            else
            {
                return NotFound("DEpartment Not VAlid");
            }
        }
    }
}
