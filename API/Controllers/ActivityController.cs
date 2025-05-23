using Application.Activities.Queries;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivityController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            //return await context.Activities.ToListAsync();
            return await Mediator.Send(new GetActivityList.Query());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivityById(string id)
        {
            //var activity = await context.Activities.FindAsync(id);
            //if (activity == null) return NotFound();
            //return activity;
            return await Mediator.Send(new GetActivityDetails.Query { Id = id });
        }
    }
}
