using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Teamify.DL.Entities;

namespace Teamify.Models.Sport
{
    public class AddSportRequestModel
    {
        public int AddSportRequestId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [Display(Name = "Name")]
        public string SportName { get; set; }

        [Required(ErrorMessage = "Description is requried.")]
        [Display(Name = "Description")]
        public string SportDescription { get; set; }

        [Required(ErrorMessage = "Rules are required.")]
        [Display(Name = "Rules")]
        public string SportRules { get; set; }

        [Display(Name = "Created on")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Requested By")]
        public string CreatedById { get; set; }

        public AddSportRequestStatus Status { get; set; }
    }
}