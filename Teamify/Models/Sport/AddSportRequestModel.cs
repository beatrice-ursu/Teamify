using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FluentValidation.Attributes;
using Teamify.Validators;

namespace Teamify.Models.Sport
{
    [Validator(typeof(AddSportRequestValidator))]
    public class AddSportRequestModel
    {
        [Display(Name = "Name")]
        public string SportName { get; set; }

        [Display(Name = "Description")]
        public string SportDescription { get; set; }

        [Display(Name = "Rules")]
        public string SportRules { get; set; }
    }
}