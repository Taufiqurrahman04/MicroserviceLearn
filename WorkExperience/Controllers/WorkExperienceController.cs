using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyCV.MediatR.Command;
using MyCV.Model.MediatR.Query;
using MyCV.ViewModel.APIViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkExperience.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkExperienceController : ControllerBase
    {
        private readonly IMediator mediator;

        public WorkExperienceController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<MyCVController>
        [HttpGet]
        public async Task<IEnumerable<ProfileViewModel>> Get()
        {
            return await mediator.Send(new GetListWorkQuery());
        }

        // GET api/<MyCVController>/5
        [HttpGet("{id}")]
        public async Task<ProfileViewModel> Get(string id)
        {
            return await mediator.Send(new GetDetailWorkQuery { Id = id });
        }

        // POST api/<MyCVController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProfileViewModel data)
        {
            var result = await mediator.Send(new CreateWorkCommand(data.CompanyName,
                data.CompanyAddress));

            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        // PUT api/<MyCVController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] ProfileViewModel data)
        {
            var result = await mediator.Send(new UpdateWorkCommand(id,
                                data.CompanyName,
                                data.CompanyAddress));

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
            var result = await mediator.Send(new DeleteWorkCommand(id));

            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}
