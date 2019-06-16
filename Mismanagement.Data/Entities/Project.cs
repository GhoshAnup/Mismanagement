using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mismanagement.Data.Entities
{
    [Table("Project")]
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(2500)]
        public string Description { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public IList<Task> Task { get; set; }

    }
}
