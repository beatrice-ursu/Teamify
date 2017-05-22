using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.DL;
using Teamify.Models.Profile;

namespace Teamify.Controllers
{
    [Authorize]
    [RoutePrefix("Profile")]
    public class ProfileController : BaseController
    {
        public ProfileController(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        // GET: Profile
        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Route("Details")]
        public ActionResult Details()
        {
            var profileEnt = CurrentUser.UserProfile;
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

        [HttpPost]
        public ActionResult Details(UserProfileModel model)
        {
            if (ModelState.IsValid)
            {
                var profileEnt = DbContext.UserProfiles.FirstOrDefault(x => x.UserProfileId == model.UserProfileId);
                if (profileEnt == null) return HttpNotFound();

                profileEnt.FirstName = model.FirstName;
                profileEnt.LastName = model.LastName;
                profileEnt.Bio = model.Bio;

                DbContext.SaveChanges();

                return RedirectToAction("Details");
            }
            return View(model);
        }

        
    }
}