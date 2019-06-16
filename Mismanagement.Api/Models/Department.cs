using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mismanagement.Api.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public IList<Project> Project { get; set; }
    }
}
