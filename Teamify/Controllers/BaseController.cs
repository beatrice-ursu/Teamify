using System.Linq;
using Microsoft.AspNet.Identity.Owin;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Teamify.DL;
using Teamify.DL.Entities;

namespace Teamify.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ApplicationDbContext Db; // => HttpContext.GetOwinContext().Get<ApplicationDbContext>();

        public BaseController()
        {
            Db = new ApplicationDbContext();
        }

        protected ApplicationUser CurrentUser
        {
            get
            {
                var userId = HttpContext.User.Identity.GetUserId();
                return Db.Users.FirstOrDefault(x => x.Id.Equals(userId));
                //return !string.IsNullOrWhiteSpace(userId) ? HttpContext.GetOwinContext()
                //    .GetUserManager<ApplicationUserManager>()
                //    .FindById(userId) : null;
            }
        }
    }
}