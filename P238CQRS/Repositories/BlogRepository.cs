using Microsoft.EntityFrameworkCore;
using P238CQRS.Entities;

namespace P238CQRS.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AppDbContext _context;
        public BlogRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ICollection<Blog>> GetAllAsync()
        {
            return await _context.Blogs.ToListAsync();
        }

        public async Task InsertAsync(Blog blog)
        {
            await _context.AddAsync(blog);
            await _context.SaveChangesAsync();
        }
    }
}
