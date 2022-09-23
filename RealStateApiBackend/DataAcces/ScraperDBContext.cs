using Microsoft.EntityFrameworkCore;
using RealStateApiBackend.Models.DataModels;

namespace RealStateApiBackend.DataAcces
{
    public class ScraperDBContext : DbContext
    {
        public ScraperDBContext(DbContextOptions<ScraperDBContext> options) : base(options)
        {

        }

        public DbSet<User>? Users { get; set; }
    }
}
