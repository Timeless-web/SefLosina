using ILHO.DOMAIN;
using ILHO.PERSISTENCE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILHO.WEBAPI.Controllers
{


    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext context;

        public ActivitiesController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]

        public List<Activity> GetActivities() { return context.Activities.ToList(); }


        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        { return await context.Activities.FindAsync(id); }
         
    }
}
