using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mismanagement.Data.Entities
{
    [Table("Gender")]
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Description { get; set; }
    }
}
