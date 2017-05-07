using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Teamify.DL.Entities
{
    public class Entity
    {
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public ApplicationUser CreatedBy { get; set; }
        [Required]
        public DateTime UpdatedOn { get; set; }
        [Required]
        public ApplicationUser UpdatedBy { get; set; }
    }
}