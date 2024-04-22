using MediatR;

namespace P238CQRS.Features.Queries.BlogGetByIdQuery
{
    public class BlogGetByIdQueryRequest: IRequest<BlogGetByIdQueryResponse>
    {
        public int Id { get; set; }
    }
}
