using MediatR;

namespace P238CQRS.Features.Queries.BlogGetAllQuery
{
    public class BlogGetAllRequest: IRequest<List<BlogGetAllResponse>>
    {

    }
}
