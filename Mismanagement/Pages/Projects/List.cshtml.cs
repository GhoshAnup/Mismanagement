using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Mismanagement.Models.Models;
using Mismanagement.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mismanagement.Pages.Projects
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IProjectService projectService;
        public IEnumerable<Project> ProjectList { get; set; }

        public ListModel(IConfiguration config,
                         IProjectService projectService)
        {
            this.config = config;
            this.projectService = projectService;
        }
        public async Task<IActionResult> OnGet()
        {
            ProjectList = await projectService.GetProjects();
            return Page();
        }
    }
}