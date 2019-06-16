using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mismanagement.Data.Entities
{
    [Table("Task")]
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int Duration { get; set; }

        public Status Status { get; set; }

        public int StatusId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }       

        //public Employee Employee { get; set; }

        //public Project Project { get; set; }
    }
}
