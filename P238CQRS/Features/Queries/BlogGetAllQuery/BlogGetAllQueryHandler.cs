using MediatR;
using P238CQRS.Repositories;

namespace P238CQRS.Features.Queries.BlogGetAllQuery
{
    public class BlogGetAllQueryHandler : IRequestHandler<BlogGetAllRequest, List<BlogGetAllResponse>>
    {
        private readonly IBlogRepository _blogRepository;

        public BlogGetAllQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;   
        }
        public async Task<List<BlogGetAllResponse>> Handle(BlogGetAllRequest request, CancellationToken cancellationToken)
        {
            var datas = await _blogRepository.GetAllAsync();

            List<BlogGetAllResponse> dtos = datas.Select(x => new BlogGetAllResponse { Id = x.Id, Name = x.Name }).ToList();
                return dtos;
        }
    }
}
