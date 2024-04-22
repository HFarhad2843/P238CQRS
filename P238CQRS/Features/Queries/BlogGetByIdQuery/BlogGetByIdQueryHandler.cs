using MediatR;

namespace P238CQRS.Features.Queries.BlogGetByIdQuery
{
    public class BlogGetByIdQueryHandler : IRequestHandler<BlogGetByIdQueryRequest, BlogGetByIdQueryResponse>
    {
        private readonly AppDbContext _context;

        public BlogGetByIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<BlogGetByIdQueryResponse> Handle(BlogGetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var blog = await _context.Blogs.FindAsync(request.Id);

            return new BlogGetByIdQueryResponse { Name = blog.Name, Id = blog.Id };
        }
    }
}
