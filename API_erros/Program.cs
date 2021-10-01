
using Microsoft.EntityFrameworkCore;

namespace API_erros.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }

        public DbSet
    }
}
