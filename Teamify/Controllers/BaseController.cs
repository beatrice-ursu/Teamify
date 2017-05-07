using Microsoft.AspNet.Identity.Owin;
using System.Web;
using System.Web.Mvc;
using Teamify.DL;

namespace Teamify.Controllers
{
    public class BaseController : Controller
    {
        protected ApplicationDbContext Db;

        public BaseController()
        {
            Db = new ApplicationDbContext();
        }
    }
}