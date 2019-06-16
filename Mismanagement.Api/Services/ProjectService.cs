using AutoMapper;
using Mismanagement.Data.Entities;
using Mismanagement.Data.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mismanagement.Api.Services
{
    public class ProjectService:IProjectService
    {
        //readonly List<Project> projects;
        private readonly IProjectRepository _projectRepository;
        //private readonly IMapper _mapper;

        public ProjectService(IProjectRepository ProjectRepository)
        {
           _projectRepository = ProjectRepository;
            // _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<IEnumerable<Project>> GetAllProject(string name)
        {
            var projectList = await _projectRepository.GetAllProject(name);
           // var result = _mapper.Map<IEnumerable<Models.Project>>(projectList);            
            return projectList;
        }

        public Project GetProjectDetail(int projectId)
        {
            var projectDetail = _projectRepository.GetProjectDetail(projectId);
            //var result = _mapper.Map<Project>(projectDetail);
            return projectDetail;
        }
    }
}
