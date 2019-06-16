
using Mismanagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mismanagement.Api.Services
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAllDepartments(string name);
    }
}
