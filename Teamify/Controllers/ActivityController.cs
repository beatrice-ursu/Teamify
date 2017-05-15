using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.Models;

namespace Teamify.Controllers
{
    public class ActivityController : Controller
    {
        public ActionResult CreateActivity()
        {
            return View("CreateActivity", new ActivityModel());
        }
    }
}