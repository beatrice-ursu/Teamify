using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.DL.Entities;
using Teamify.Helpers;
using Teamify.Models.Sport;

namespace Teamify.Controllers
{
    [Authorize]
    public class SportController : BaseController
    {
        public ActionResult CreateNewSportView(int id)
        {
            var requestModel = Db.AddSportRequests.FirstOrDefault(x => x.AddSportRequestId == id);
            var createModel = new CreateSportModel
            {
                AddSportRequestId = id,
                RequestSportName = requestModel.SportName,
                RequestSportDescription = requestModel.SportDescription,
                RequestSportRules = requestModel.SportRules
            };
            return View("CreateNewSportView", createModel);
        }

        public ActionResult CreateSport(CreateSportModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var createSport = new Sport
                    {
                        Name = model.NewSportName,
                        Description = model.NewSportDescription,
                        Rules = model.NewSportRules
                    };
                    createSport.AddAudit(CurrentUser);
                    Db.Sports.Add(createSport);

                    var updateSport = Db.AddSportRequests.FirstOrDefault(x => x.AddSportRequestId == model.AddSportRequestId);
                    updateSport.RequestStatus = AddSportRequestStatus.Accepted;
                    Db.AddSportRequests.AddOrUpdate(updateSport);
                    Db.SaveChanges();
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Something went wrong. Please try again");
                    return RedirectToAction("CreateNewSportView", model.AddSportRequestId);
                }
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("CreateNewSportView", model.AddSportRequestId);
        }

        public ActionResult SportDetailsView(int id)
        {
            var dbmodel = Db.Sports.FirstOrDefault(x => x.SportId == id);
            var model = new SportModel
            {
                Name = dbmodel.Name,
                Description = dbmodel.Description,
                Rules = dbmodel.Rules
            };

            return View("SportDetailsView", model);
        }
    }
}