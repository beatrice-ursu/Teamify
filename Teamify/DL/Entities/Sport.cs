using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Teamify.DL.Entities
{
    public class Sport : Entity
    {
        public int SportId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Rules { get; set; }
        public virtual ICollection<UserProfile> UsersFavorite { get; set; }
    }
}