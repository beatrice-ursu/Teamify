using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.Models.Sport;

namespace Teamify.Controllers
{
    public class SportRequestController : BaseController
    {
        // GET: SportRequest
        public ActionResult AddSportView()
        {
            return View("AddSportRequestView", new AddSportRequestModel());
        }

        public void AddSportRequest(AddSportRequestModel model)
        {
            if (ModelState.IsValid)
            {
                
            }
            
        }
    }
}