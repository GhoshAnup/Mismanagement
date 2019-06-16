using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mismanagement.Data.Entities
{
    [Table("Status")]
   public class Status
    {
        [Key]
        public int StatusId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Description { get; set; }
    }
}
