using System.ComponentModel.DataAnnotations;

namespace Teamify.Models.Profile
{
    public class UserProfileModel
    {
        public int UserProfileId { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string Bio { get; set; }
        public float Rating { get; set; }
    }
}