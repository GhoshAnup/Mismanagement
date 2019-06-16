
using Microsoft.AspNetCore.Mvc.Rendering;
using Mismanagement.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mismanagement.Services
{
    public interface IDepartmentService
    {
       IEnumerable<Department> GetAllDepartments();
        IEnumerable<SelectListItem> PopulateDepartmentList();
    }
}
