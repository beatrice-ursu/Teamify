using System.Linq;
using System.Web.Http;
using DataTables.AspNet.Core;
using Teamify.DL;
using Teamify.Models.People;

namespace Teamify.ApiControllers
{
    [RoutePrefix("api/People")]
    public class PeopleController : BaseApiController
    {
        public PeopleController(ApplicationDbContext db) : base(db)
        {
        }

        // GET: People
        [Route("GetPeople")]
        [HttpGet]
        public IHttpActionResult GetPeople(IDataTablesRequest objRequest)
        {
            var list = DbContext.UserProfiles.Select(x => new UserModel()
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