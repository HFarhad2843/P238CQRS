using P238CQRS.Controllers;
using P238CQRS.Entities;


namespace P238CQRS.Repositories
{
    public interface IBlogRepository
    {
        Task InsertAsync(Blog blog);
        Task<ICollection<Blog>> GetAllAsync();

    }
}
