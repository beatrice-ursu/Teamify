using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.DL;
using Teamify.DL.Entities;
using Teamify.Helpers;
using Teamify.Models.Sport;

namespace Teamify.Controllers
{
    [Authorize]
    public class SportRequestController : BaseController
    {
        public SportRequestController(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        // GET: SportRequest
        public ActionResult CreateSportRequest()
        {
            return View("CreateSportRequest", new AddSportRequestModel());
        }

        [HttpPost]
        public ActionResult CreateSportRequest(AddSportRequestModel model)
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

                    DbContext.AddSportRequests.Add(addSportRequest);
                    DbContext.SaveChanges();
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Something went wrong. Please try again");
                    return View("CreateSportRequest", model);
                }
                return RedirectToAction("Index", "Home");
            }
            return View("CreateSportRequest", model);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult SportsRequestsList()
        {
            var model = DbContext.AddSportRequests.Select(x => new AddSportRequestModel
            {
                AddSportRequestId = x.AddSportRequestId,
                SportName = x.SportName,
                SportDescription = x.SportDescription,
                SportRules = x.SportRules,
                CreatedById = x.CreatedBy.UserName,
                CreatedOn = x.CreatedOn,
                Status = x.RequestStatus
            }).Where(z => z.Status == AddSportRequestStatus.Pending).ToList();

            return View("SportsRequestsList", model);
        }

        //[Authorize(Roles = "Administrator")]
        //public ActionResult SportRequestDetails(int id)
        //{
        //    var modelDefault = DbContext.AddSportRequests.FirstOrDefault(x => x.AddSportRequestId == id);
        //    var model = new AddSportRequestModel
        //    {
        //        AddSportRequestId = modelDefault.AddSportRequestId,
        //        SportName = modelDefault.SportName,
        //        SportDescription = modelDefault.SportDescription,
        //        SportRules = modelDefault.SportRules
        //    };

        //    return View("SportRequestDetailsView", model);

        //}
    }
}