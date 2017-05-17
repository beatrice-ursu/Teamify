using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.Models.People;

namespace Teamify.Controllers
{
    public class PeopleController : BaseController
    {
        public ActionResult List()
        {
            return View("List");
        }
    }
}