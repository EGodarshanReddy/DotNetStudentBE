using EGR_APIs_DotNet.Models;
using Microsoft.EntityFrameworkCore;

namespace EGR_APIs_DotNet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
