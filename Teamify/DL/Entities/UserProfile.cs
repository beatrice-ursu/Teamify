using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teamify.DL.Entities
{
    public class UserProfile : Entity
    {
        public int UserProfileId { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string Bio { get; set; }
        [DefaultValue(5)]
        public float Rating { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}