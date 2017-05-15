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
        public ActionResult CreateSport(int id)
        {
            var requestModel = Db.AddSportRequests.FirstOrDefault(x => x.AddSportRequestId == id);

            if (requestModel == null)
                return HttpNotFound();

            var createModel = new CreateSportModel
            {
                AddSportRequestId = id,
                RequestSportName = requestModel.SportName,
                RequestSportDescription = requestModel.SportDescription,
                RequestSportRules = requestModel.SportRules
            };
            return View("CreateSport", createModel);
        }

        [HttpPost]
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
                    if (updateSport != null)
                    {
                        updateSport.RequestStatus = AddSportRequestStatus.Accepted;
                        Db.AddSportRequests.AddOrUpdate(updateSport);
                    }

                    Db.SaveChanges();
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Something went wrong. Please try again");
                    return RedirectToAction("CreateSport", model.AddSportRequestId);
                }
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("CreateSport", model.AddSportRequestId);
        }

        public ActionResult SportDetails(int id)
        {
            var dbmodel = Db.Sports.FirstOrDefault(x => x.SportId == id);

            if (dbmodel == null)
                return HttpNotFound();

            var model = new SportModel
            {
                Name = dbmodel.Name,
                Description = dbmodel.Description,
                Rules = dbmodel.Rules
            };

            return View("SportDetails", model);
        }

        public ActionResult SportsList()
        {
            var model = Db.Sports.Select(x => new SportModel
            {
                Name = x.Name,
                SportId = x.SportId

            }).ToList();

            return PartialView("_SportsListPartial", model);
        }
    }
}