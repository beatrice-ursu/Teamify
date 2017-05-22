using System.Web.Http;
using Teamify.DL;
using Teamify.Models;

namespace Teamify.ApiControllers
{
    [RoutePrefix("api/Activity")]
    public class ActivityController : BaseApiController
    {
        public ActivityController(ApplicationDbContext db) : base(db)
        {
        }

        [Route("Create")]
        [HttpPost]
        public IHttpActionResult Create(ActivityModel model)
        {
            return Ok(model);
        }
    }
}
