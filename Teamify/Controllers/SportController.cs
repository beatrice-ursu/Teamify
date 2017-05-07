using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.Models.Sport;

namespace Teamify.Controllers
{
    public class SportController : Controller
    {
        // GET: Sport
        public ActionResult AddSportView()
        {
            return View("AddSportView", new Sport());
        }
    }
}