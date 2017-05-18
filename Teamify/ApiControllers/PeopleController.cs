using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DataTables.AspNet.Core;
using Teamify.Models.People;

namespace Teamify.ApiControllers
{
    [RoutePrefix("api/People")]
    public class PeopleController : BaseApiController
    {
        // GET: People
        [System.Web.Http.Route("GetPeople")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetPeople(IDataTablesRequest objRequest)
        {
            var list = Db.UserProfiles.Select(x => new UserModel()
            {
                Name = x.LastName + x.FirstName,
                Bio = x.Bio,
                Rating = x.Rating

            }).ToList();

            //var list = new List<UserModel>();

            return Ok(list);
        }
    }
}