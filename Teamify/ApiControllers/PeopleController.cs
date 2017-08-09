using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Teamify.DL;
using Teamify.Models.People;
using Teamify.Models.Shared;

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
        public IHttpActionResult GetPeople()
        {
            var list = DbContext.UserProfiles.Select(x => new UserModel()
            {
                Name = x.LastName + " " + x.FirstName,
                Bio = x.Bio,
                Rating = x.Rating
            }).ToList();

            return Ok(list);
        }

        [Route("Filter")]
        [HttpPost]
        public IHttpActionResult Filter(FilterPeopleModel filter)
        {
            var filterOutIds = filter.FilterOut?.Where(x => x != null).Select(x => x.Value).ToList() ?? new List<int>();
            var query = DbContext.UserProfiles.Where(userProfile => !filterOutIds.Contains(userProfile.UserProfileId));
            if (!string.IsNullOrWhiteSpace(filter.Filter))
            {
                query = query.Where(userProfile => userProfile.FirstName.ToLower().Contains(filter.Filter.ToLower()) ||
                                                   userProfile.LastName.ToLower().Contains(filter.Filter.ToLower()));
            }
            var results = query.Take(15).ToList();
            var result = results.Select(userProfile => new SelectModel<string, int>(
                $"{userProfile.FirstName} {userProfile.LastName}",
                userProfile.UserProfileId));
            return Ok(result);
        }
    }
}