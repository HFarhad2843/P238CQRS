using MediatR;

namespace P238CQRS.Features.Commands
{
    public class BlogPostRequest: IRequest<BlogPostResponse>
    {
        public string Name { get; set; }
    }
}
