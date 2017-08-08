using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teamify.DL.Entities
{
    public class Entity
    {
        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string CreatedById { get; set; }
        [ForeignKey("CreatedById")]
        public virtual User CreatedBy { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        [Required]
        public string UpdatedById { get; set; }
        [ForeignKey("UpdatedById")]
        public virtual User UpdatedBy { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}