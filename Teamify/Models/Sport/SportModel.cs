using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Teamify.Models.Sport
{
    public class SportModel
    {
        public int SportId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Rules { get; set; }
    }
}