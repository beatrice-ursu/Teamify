using System.ComponentModel.DataAnnotations;

namespace Teamify.Models.Sport
{
    public class CreateSportModel
    {
        public int AddSportRequestId { get; set; }

        [Display(Name = "Name")]
        public string RequestSportName { get; set; }

        [Display(Name = "Description")]
        public string RequestSportDescription { get; set; }

        [Display(Name = "Rules")]
        public string RequestSportRules { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [Display(Name = "Name")]
        public string NewSportName { get; set; }

        [Required(ErrorMessage = "Description is requried.")]
        [Display(Name = "New sport description")]
        public string NewSportDescription { get; set; }

        [Required(ErrorMessage = "Rules are required.")]
        [Display(Name = "New sport rules")]
        public string NewSportRules { get; set; }
    }
}