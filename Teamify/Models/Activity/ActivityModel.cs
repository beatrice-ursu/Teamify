using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Teamify.Models.Activity
{
    public class ActivityModel
    {
        public int ActivityId { get; set; }

        [Display(Name = "Min. players")]
        public int MinPlayers { get; set; }

        [Display(Name = "Max. players")]
        public int MaxPlayers { get; set; }

        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Display(Name = "Expire Date")]
        public DateTime ExpireDate { get; set; }

        [Display(Name = "Min. rating")]
        public float MinPlayersRating { get; set; }

        public string Description { get; set; }

        [Display(Name = "Location")]
        public string LocationId { get; set; }

        [Display(Name = "Sport")]
        public int SportId { get; set; }

        [Display(Name = "Invite players")]
        public IEnumerable<int> PossiblePlayers { get; set; }
    }
}