using Business_Layer.IService;
using EMS.Data.Services.IData;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationController : ControllerBase
    {
        private readonly IDesignationservice Des;
        public DesignationController(IDesignationservice Des)
        {
            this.Des = Des;
        }
        // GET: api/<DesignationController>
        [HttpGet]
        public IEnumerable<Designation> Get()
        {
            return Des.GetDesignations();
        }
    }
}
