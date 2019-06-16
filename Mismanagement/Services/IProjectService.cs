
using Mismanagement.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mismanagement.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetProjects();
        Project GetProjectDetailById(int projectId);
    }
}
