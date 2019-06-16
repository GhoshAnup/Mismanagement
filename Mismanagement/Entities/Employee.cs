using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mismanagement.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public int Gender { get; set; }

        public string SkillSet { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public IList<Task> Task { get; set; }
    }
}
