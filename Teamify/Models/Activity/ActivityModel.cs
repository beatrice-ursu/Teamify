using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Teamify.Models.Profile;

namespace Teamify.Models
{
    public class ActivityModel
    {
        public int Activity { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpireDate { get; set; }
        public float? MinPlayersRating { get; set; }
        public string Description { get; set; }
        public int SportId { get; set; }
        public string Location { get; set; }
        public IList<UserProfileModel> PossiblePlayers { get; set; }
    }
}