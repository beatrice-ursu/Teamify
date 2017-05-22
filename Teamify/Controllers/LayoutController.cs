using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.DL;
using Teamify.Models.Sport;

namespace Teamify.Controllers
{
    public class LayoutController : BaseController
    {
        // GET: Layout
        public LayoutController(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}