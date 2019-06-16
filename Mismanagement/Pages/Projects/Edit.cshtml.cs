using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mismanagement.Models.Models;
using Mismanagement.Services;

namespace Mismanagement.Pages.Projects
{
    public class EditModel : PageModel
    {
        private readonly IProjectService projectService;
        public IDepartmentService DepartmentService { get; }

        public Project ProjectDetail { get; set; }

        [BindProperty]
        public Project Project { get; set; }
        public IEnumerable<SelectListItem> Departments { get; set; }

        public EditModel(IProjectService projectService, IDepartmentService departmentService)
        {
            this.projectService = projectService;
            DepartmentService = departmentService;
        }
        public IActionResult OnGet(int? projectId)
        {
            Departments = DepartmentService.PopulateDepartmentList();
            if (projectId.HasValue)
            {
                Project = projectService.GetProjectDetailById(projectId.Value);
            }
            else
            {
                Project = new Project();
            }
            if (Project == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("./Detail", new { ProjectId = Project.ProjectId });
        }

    }
}