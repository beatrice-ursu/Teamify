using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.Models.Sport;

namespace Teamify.Controllers
{
    public class LayoutController : BaseController
    {
        // GET: Layout
        public ActionResult GetSportsList()
        {
            var model = Db.Sports.Select(x => new SportModel
            {
                Name = x.Name
            }).ToList();
            
            return PartialView("_SportsListPartial", model);
        }
}
}