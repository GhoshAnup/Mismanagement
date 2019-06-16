using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mismanagement.Models.Models;
using Mismanagement.Services;

namespace Mismanagement.Pages.Projects
{
    public class DetailModel : PageModel
    {
        private readonly IProjectService projectService;
        public Project ProjectDetail { get; set; }

        public DetailModel(IProjectService projectService)
        {
            this.projectService = projectService;
        }
        public void OnGet(int projectId)
        {
            ProjectDetail=projectService.GetProjectDetailById(projectId);
        }
    }
}