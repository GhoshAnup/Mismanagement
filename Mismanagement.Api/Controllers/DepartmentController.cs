using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mismanagement.Api.Services;
using Mismanagement.Models.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mismanagement.Api.Controllers
{
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;

        public DepartmentController(IDepartmentService DepartmentService, IMapper mapper)
        {
            this._departmentService = DepartmentService;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get(string name)
        {
            var departments = _departmentService.GetAllDepartments(name);
            var result = _mapper.Map<IEnumerable<Department>>(departments);
            return Ok(result);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
