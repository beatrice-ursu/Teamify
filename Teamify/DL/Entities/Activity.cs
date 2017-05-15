using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Teamify.DL.Entities
{
    public class Activity: Entity
    {
        public int ActivityId { get; set; }

        [Required]
        public int MinPlayers { get; set; }

        [Required]
        public int MaxPlayers { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime ExpireDate { get; set; }

        public float? MinPlayersRating { get; set; }

        public string Description { get; set; }

        [Required]
        public virtual Sport Sport { get; set; }

        [Required]
        public string Location { get; set; }

        public virtual ICollection<UserProfile> Players { get; set; }

        public virtual ICollection<UserProfile> PossiblePlayers { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    }
}