using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.DL;
using Teamify.Models.People;

namespace Teamify.Controllers
{
    public class PeopleController : BaseController
    {
        public PeopleController(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public ActionResult List()
        {
            return View("List");
        }
    }
}