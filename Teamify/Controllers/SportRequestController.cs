using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.DL.Entities;
using Teamify.Helpers;
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

        public ActionResult AddSportRequest(AddSportRequestModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var addSportRequest = new AddSportRequest
                    {
                        SportName = model.SportName,
                        SportDescription = model.SportDescription,
                        SportRules = model.SportRules,
                        RequestStatus = AddSportRequestStatus.Pending
                    };
                    addSportRequest.AddAudit(CurrentUser);

                    Db.AddSportRequests.Add(addSportRequest);
                    Db.SaveChanges();
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Something went wrong. Please try again");
                    return View("AddSportRequestView", model);
                }
                return RedirectToAction("Index", "Home");
            }
            return View("AddSportRequestView", model);
        }
    }
}