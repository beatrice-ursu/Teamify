using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.Models.Profile;

namespace Teamify.Controllers
{
    [Authorize]
    [RoutePrefix("Profile")]
    public class ProfileController : BaseController
    {
        // GET: Profile
        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Route("Details/{profileId}")]
        public ActionResult Details(int profileId)
        {
            var profileEnt = Db.UserProfiles.FirstOrDefault(x => x.UserProfileId == profileId);
            if (profileEnt != null)
            {
                var model = new UserProfileModel
                {
                    FirstName = profileEnt.FirstName,
                    Bio = profileEnt.Bio,
                    LastName = profileEnt.LastName,
                    UserProfileId = profileEnt.UserProfileId,
                    Rating = profileEnt.Rating
                };
             return View(model);
            }
            return HttpNotFound();
        }

        public ActionResult Details(UserProfileModel model)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View(model);
        }
    }
}