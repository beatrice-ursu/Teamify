using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FluentValidation.Attributes;
using Teamify.DL.Entities;
using Teamify.Validators;

namespace Teamify.Models.Sport
{
    [Validator(typeof(AddSportRequestValidator))]
    public class AddSportRequestModel
    {
        public int AddSportRequestId { get; set; }

        [Display(Name = "Name")]
        public string SportName { get; set; }

        [Display(Name = "Description")]
        public string SportDescription { get; set; }

        [Display(Name = "Rules")]
        public string SportRules { get; set; }

        [Display(Name = "Created on")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Requested By")]
        public string CreatedById { get; set; }

        public AddSportRequestStatus Status { get; set; }
    }
}