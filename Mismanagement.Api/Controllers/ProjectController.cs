using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mismanagement.Api.Services;
using Mismanagement.Models.Models;

namespace Mismanagement.Api.Controllers
{
    [Route("api/project")]
    public class ProjectController : Controller
    {
        private readonly IProjectService projectService;
        private readonly IMapper _mapper;

        public ProjectController(IProjectService projectService, IMapper mapper)
        {
            this.projectService = projectService;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: api/<controller>
        [HttpGet]
        //[ProjectFilter]      
        public async Task<IActionResult> Get(string name)
        {
            var projectList = await projectService.GetAllProject(name);
            var result = _mapper.Map<IEnumerable<Project>>(projectList);
            return Ok(result);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]       
        public ActionResult Get(int id)
        {
            var projectDetail = projectService.GetProjectDetail(id);
            var result = _mapper.Map<Project>(projectDetail);
            return Ok(result);           
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
