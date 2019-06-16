using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mismanagement.Data.Entities
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]       
        public int Gender { get; set; }

        [Required]
        [MaxLength(500)]
        public string SkillSet { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public IList<Task> Task { get; set; }
    }
}
