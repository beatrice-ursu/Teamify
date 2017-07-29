using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Teamify.Models.Activity
{
    public class ActivityCreateModel
    {
        public int ActivityId { get; set; }

        [Required]
        [Display(Name = "Min. players")]
        public int MinPlayers { get; set; }

        [Required]
        [Display(Name = "Max. players")]
        public int MaxPlayers { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Expire Date")]
        public DateTime ExpireDate { get; set; }

        [Required]
        [Display(Name = "Min. rating")]
        public float MinPlayersRating { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Location")]
        public string LocationId { get; set; }

        [Required]
        [Display(Name = "Sport")]
        public int SportId { get; set; }

        [Display(Name = "Invite players")]
        public IEnumerable<int> PossiblePlayers { get; set; }
    }
}