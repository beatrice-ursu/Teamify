using System.Web.Http;
using Teamify.Models;
using Teamify.Models.Activity;

namespace Teamify.ApiControllers
{
    [RoutePrefix("api/Activity")]
    public class ActivityController : BaseApiController
    {
        [Route("Create")]
        [HttpPost]
        public IHttpActionResult Create(ActivityModel model)
        {
            return Ok(model);
        }
    }
}