
using Mismanagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mismanagement.Data.Repos
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments(string name);
    }
}
