using EMS.Data.Services.IData;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDep dep;
        public DepartmentController(IDep dep)
        {
            this.dep = dep;
        }
        // GET: api/<DepartmentController>
         [HttpGet]
        public IEnumerable<Department> Get()
        {
            return dep.GetDepartments();
        }
    }
}
