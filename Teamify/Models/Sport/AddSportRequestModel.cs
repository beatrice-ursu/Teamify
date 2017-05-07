using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Teamify.Models.Sport
{
    public class AddSportRequestModel
    {
        [Required(ErrorMessage = "Name is required!")]
        [Display(Name = "Name")]
        public string SportName { get; set; }

        [Required(ErrorMessage = "Description is required!")]
        [Display(Name = "Description")]
        public string SportDescription { get; set; }

        [Required(ErrorMessage = "Rules are required!")]
        [Display(Name = "Rules")]
        public string SprotRules { get; set; }
    }
}