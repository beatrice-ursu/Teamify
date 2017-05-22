using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teamify.DL;
using Teamify.Models;

namespace Teamify.Controllers
{
    [Authorize]
    public class ActivityController : BaseController
    {
        //public ActionResult CreateActivity()
        //{
        //    var model = new ActivityModel
        //    {
        //        Date = DateTime.Now,
        //        ExpireDate = DateTime.Now
        //    };

        //    return PartialView("_CreateActivityModal", model);
        //}
        public ActivityController(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}