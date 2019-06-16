using System;
using System.Collections.Generic;
using System.Text;

namespace Mismanagement.Models.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public IList<Project> Project { get; set; }
    }
}
