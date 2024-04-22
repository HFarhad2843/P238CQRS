using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P238CQRS.Features.Commands;
using P238CQRS.Features.Queries.BlogGetAllQuery;
using P238CQRS.Features.Queries.BlogGetByIdQuery;


namespace P238CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator mediator;

        public BlogsController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpPost("")]
        public async Task<IActionResult> Post(BlogPostRequest dto)
        => Ok(await mediator.Send(dto));

        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            BlogGetAllRequest blogGetAllRequest = new BlogGetAllRequest();
            return Ok(await mediator.Send(blogGetAllRequest));
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(int id)
        {
            BlogGetByIdQueryRequest request = new BlogGetByIdQueryRequest { Id = id };
            return Ok(await mediator.Send(request));
        }
    }
}
