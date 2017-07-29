using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Teamify.DL;
using Teamify.DL.Entities;
using Teamify.Filters;
using Teamify.Helpers;
using Teamify.Models;
using Teamify.Models.Activity;

namespace Teamify.ApiControllers
{
    [RoutePrefix("api/Activity")]
    public class ActivityController : BaseApiController
    {
        public ActivityController(ApplicationDbContext db) : base(db)
        {
        }

        [Authorize]
        [Route("Create")]
        [HttpPost]
        [ValidateModel]
        public IHttpActionResult Create(ActivityCreateModel model)
        {
            if (model == null) return BadRequest("Model can't be empty.");
            try
            {
                var activity = new Activity
                {
                    Date = model.Date,
                    Description = model.Description,
                    ExpireDate = model.ExpireDate,
                    Location = model.LocationId,
                    MaxPlayers = model.MaxPlayers,
                    MinPlayers = model.MinPlayers,
                    MinPlayersRating = model.MinPlayersRating,
                    Sport = DbContext.Sports.FirstOrDefault(x => x.SportId == model.SportId),
                    PossiblePlayers = DbContext.UserProfiles.Where(x => model.PossiblePlayers != null && model.PossiblePlayers.Contains(x.UserProfileId)).ToList(),
                    Players = DbContext.UserProfiles.Where(x => x.UserProfileId == CurrentUser.UserProfile.UserProfileId).ToList()
                };
                activity.AddAudit(CurrentUser);

                DbContext.Activities.Add(activity);
                DbContext.SaveChanges();

                return Ok(activity.ActivityId);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
