using Mismanagement.Data.Context;
using Mismanagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Mismanagement.Data.Repos
{
    public class ProjectRepository: IProjectRepository
    {
       // readonly List<Project> projects;
        private readonly MismanagementDbContext _context;

        public ProjectRepository(MismanagementDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

            //projects = new List<Project>()
            //{
            //    new Project { ProjectId = 1, Name = "Scott's Pizza", Description="Maryland"},
            //    new Project { ProjectId = 2, Name = "Cinnamon Club", Description="London"},
            //    new Project { ProjectId = 3, Name = "La Costa", Description = "California"}
            //};
        }

        public  async Task<IEnumerable<Project>> GetAllProject(string name)
        {
            //return await _context.Project.Include(b => b.Task).ToListAsync();

            return await _context.Project.Include(b => b.Task)
                        .Where(c=>c.Name.StartsWith(name) || string.IsNullOrEmpty(name)).ToListAsync();
            
            //from r in _context.Project
            //        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
            //        orderby r.Name
            //        select r;
            //  return query;
            //return await query;
        }
        public Project GetProjectDetail(int projectId)
        {
            var result = _context.Project.Include(b => b.Task)
                        .Where(c => c.ProjectId == projectId);
            return result.First();
        }
    }
}
