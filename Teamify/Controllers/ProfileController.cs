using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

            return View();
        }
    }
}