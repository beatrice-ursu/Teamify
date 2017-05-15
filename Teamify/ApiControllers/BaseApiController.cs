using System.Linq;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Teamify.DL;
using Teamify.DL.Entities;

namespace Teamify.ApiControllers
{
    public class BaseApiController : ApiController
    {
        protected readonly ApplicationDbContext Db;

        public BaseApiController()
        {
            Db = new ApplicationDbContext();    
        }

        protected User CurrentUser
        {
            get
            {
                var userId = HttpContext.Current.User.Identity.GetUserId();
                return Db.Users.FirstOrDefault(x => x.Id.Equals(userId));
            }
        }
    }
}