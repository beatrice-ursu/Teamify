using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using Teamify.Validators;

namespace Teamify.Models.Sport
{
    [Validator(typeof(CreateSportValidator))]
    public class CreateSportModel
    {
        public int AddSportRequestId { get; set; }

        [Display(Name = "Name")]
        public string RequestSportName { get; set; }

        [Display(Name = "Description")]
        public string RequestSportDescription { get; set; }

        [Display(Name = "Rules")]
        public string RequestSportRules { get; set; }

        [Display(Name = "Name")]
        public string NewSportName { get; set; }

        [Display(Name = "New sport description")]
        public string NewSportDescription { get; set; }

        [Display(Name = "New sport rules")]
        public string NewSportRules { get; set; }
    }
}