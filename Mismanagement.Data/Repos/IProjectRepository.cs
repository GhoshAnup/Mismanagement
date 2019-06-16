using Mismanagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mismanagement.Data.Repos
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetAllProject(string name);
        Project GetProjectDetail(int projectId);
    }

}
