using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorkExperience.CQRS.MediatR.Command;
using WorkExperience.CQRS.MediatR.Query;
using WorkExperience.ViewModel.APIViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkExperience.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyWorkExperienceController : ControllerBase
    {
        // GET: api/<MyWorkExperienceController>
        private readonly IMediator mediator;

        public MyWorkExperienceController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<MyCVController>
        [HttpGet]
        public async Task<IEnumerable<MyWorkExperienceViewModel>> Get()
        {
            return await mediator.Send(new GetListMyWorkQuery());
        }

        // GET api/<MyCVController>/5
        [HttpGet("{id}")]
        public async Task<MyWorkExperienceViewModel> Get(string id)
        {
            return await mediator.Send(new GetDetailMyWorkQuery { Id = id });
        }

        // POST api/<MyCVController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MyWorkExperienceViewModel data)
        {
            var result = await mediator.Send(new CreateMyWorkCommand(data.UserRefId,
                data.ProfileId,
                data.DateStart,
                data.DateEnd,
                data.IsCurrent,
                data.JobTitle));

            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        // PUT api/<MyCVController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] MyWorkExperienceViewModel data)
        {
            var result = await mediator.Send(new UpdateMyWorkCommand(id,
                                data.UserRefId,
                                data.ProfileId,
                                data.DateStart,
                                data.DateEnd,
                                data.IsCurrent,
                                data.JobTitle));

            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        // DELETE api/<MyCVController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await mediator.Send(new DeleteMyWorkCommand(id));

            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}
