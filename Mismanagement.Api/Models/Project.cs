using System;
using System.Collections.Generic;


namespace Mismanagement.Api.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public IList<Task> Task { get; set; }
    }
}
