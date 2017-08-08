using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Teamify.DL;
using Teamify.Models.Shared;
using Teamify.Models.Sport;

namespace Teamify.ApiControllers
{
    [RoutePrefix("api/Sport")]
    public class SportController : BaseApiController
    {
        public SportController(ApplicationDbContext db) : base(db) {}

        //GET SportModel
        [Route("GetAvailable")]
        [HttpGet]
        public IHttpActionResult GetAvailable()
        {
            var sports = DbContext.Sports.Where(x => x.IsActive)
                .Select(x => new SelectModel<string, int>
                {
                    Text = x.Name,
                    Value = x.SportId
                }).ToList();

            return Ok(sports);
        }
    }
}
