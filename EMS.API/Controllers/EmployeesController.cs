using Business_Layer.IService;
using EMS.Data.Services.IData;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;



namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase

    {
        private readonly IEmp ems;
        public EmployeesController(IEmp ems)
        {
            this.ems = ems;
        }
        // GET: api/<EmpController>
        [HttpGet]
        public IEnumerable<Employees> Get()
        {
            return ems.GetEmployees();
        }

        // GET api/<EmpController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmpController>
        [HttpPost]
        public void Post(Employees employee)
        {
            ems.CreateEmployees(employee);
        }

        // PUT api/<EmpController>/5
        [HttpPut("{id}")]
        public void Put(int Empid,Employees employees)
        {
            ems.UpdateEmployees(employees);
        }

        // DELETE api/<EmpController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ems.DeleteEmployees(id);
        }
    }
}
