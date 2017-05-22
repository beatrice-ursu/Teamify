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
        protected readonly ApplicationDbContext DbContext;

        public BaseController(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        protected User CurrentUser
        {
            get
            {
                var userId = HttpContext.User.Identity.GetUserId();
                return DbContext.Users.FirstOrDefault(x => x.Id.Equals(userId));
                //return !string.IsNullOrWhiteSpace(userId) ? HttpContext.GetOwinContext()
                //    .GetUserManager<ApplicationUserManager>()
                //    .FindById(userId) : null;
            }
        }
    }
}