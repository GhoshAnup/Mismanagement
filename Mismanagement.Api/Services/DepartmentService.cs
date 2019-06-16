using Mismanagement.Data.Entities;
using Mismanagement.Data.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mismanagement.Api.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository DepartmentRepository)
        {
            _departmentRepository = DepartmentRepository;
        }
        public IEnumerable<Department> GetAllDepartments(string name)
        {
            return _departmentRepository.GetAllDepartments(name);
        }
    }
}

