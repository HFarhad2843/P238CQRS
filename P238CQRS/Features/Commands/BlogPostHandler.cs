using MediatR;
using Microsoft.IdentityModel.Tokens;
using P238CQRS.Entities;
using P238CQRS.Repositories;

namespace P238CQRS.Features.Commands
{
    public class BlogPostHandler : IRequestHandler<BlogPostRequest, BlogPostResponse>
    {
        private readonly IBlogRepository _blogRepository;

        public BlogPostHandler(IBlogRepository blogRepository)
             
        {
            _blogRepository = blogRepository;
        }

        public async Task<BlogPostResponse> Handle(BlogPostRequest request, CancellationToken cancellationToken)
        {
            Blog blog = new Blog
            {
                IsDeleted = false,
                Name = request.Name,
            };
            await _blogRepository.InsertAsync(blog);
            return new BlogPostResponse { Id = blog.Id,Name = blog.Name};
        }
    }
}
