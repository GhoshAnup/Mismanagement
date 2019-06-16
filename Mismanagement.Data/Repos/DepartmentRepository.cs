using Mismanagement.Data.Context;
using Mismanagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Mismanagement.Data.Repos
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly MismanagementDbContext _context;
        public DepartmentRepository(MismanagementDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }
        public IEnumerable<Department> GetAllDepartments(string name)
        {
            return _context.Department.Where(c => c.Name.StartsWith(name) || string.IsNullOrEmpty(name)).ToList();

        }
    }

}
