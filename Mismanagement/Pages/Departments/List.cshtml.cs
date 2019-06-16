using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Mismanagement.Models.Models;
using Mismanagement.Services;

namespace Mismanagement.Pages.Departments
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
       
        public IEnumerable<Department> DepartmentList { get; set; }
        public IDepartmentService DepartmentService { get; }

        public ListModel(IConfiguration config,
                         IDepartmentService departmentService)
        {
            this.config = config;
            this.DepartmentService = departmentService;
        }
        public IActionResult OnGet()
        {
            DepartmentList =  DepartmentService.GetAllDepartments();
            return Page();
        }
    }
}