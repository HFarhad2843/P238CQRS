using Microsoft.EntityFrameworkCore;
using P238CQRS.Entities;
using System.Security.Cryptography.X509Certificates;

namespace P238CQRS
{
    public class AppDbContext: DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        public  DbSet<Blog> Blogs { get; set; }
    }
}
