using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Teamify.Models.People
{
    public class UserModel
    {
        public int UserProfileId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Bio { get; set; }
        public float Rating { get; set; }
    }
}