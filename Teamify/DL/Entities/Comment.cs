using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Teamify.DL.Entities
{
    public class Comment: Entity
    {
        public int CommentId { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public virtual Activity Activity { get; set; }
    }
}