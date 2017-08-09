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
        [Route("AddActivity")]
        [HttpPost]
        [ValidateModel]
        public IHttpActionResult AddActivity(ActivityCreateModel model)
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
                    Players = DbContext.UserProfiles.Where(x => x.UserProfileId == CurrentUser.UserProfile.UserProfileId).ToList()
                };
                if (model.InvitedPeople.Count > 0)
                {
                    var invitedPeople = model.InvitedPeople.Select(x => x.Value).ToList();
                    activity.PossiblePlayers = DbContext.UserProfiles
                        .Where(x => invitedPeople.Contains(x.UserProfileId)).ToList();
                }

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
