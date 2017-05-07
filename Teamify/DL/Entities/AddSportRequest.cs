using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Teamify.DL.Entities
{
    public class AddSportRequest : Entity
    {
        public int AddSportRequestId { get; set; }
        [Required]
        public string SportName { get; set; }
        [Required]
        public string SportDescription { get; set; }
        public string SprotRules { get; set; }
        [DefaultValue(AddSportRequestStatus.Pending)]
        public AddSportRequestStatus RequestStatus { get; set; }
    }

    public enum AddSportRequestStatus
    {
        Pending,
        Accepted,
        Rejected
    }
}