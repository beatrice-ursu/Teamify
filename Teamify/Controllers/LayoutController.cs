using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.Models.Sport;

namespace Teamify.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        //use DB here 
        public ActionResult GetSportsList()
        {
            var model = new List<Sport>();
            for (int i = 0; i < 4; i++)
            {
                var newSport = new Sport
                {
                    Name = "Sport" + i
                };
                model.Add(newSport);
            }

            return PartialView("_SportsListPartial", model);
        }
}
}