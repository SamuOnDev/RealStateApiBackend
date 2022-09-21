using Microsoft.EntityFrameworkCore;
using WebScraperApiBackend.Models.DataModels;

namespace WebScraperApiBackend.DataAcces
{
    public class ScraperDBContext : DbContext
    {
        public ScraperDBContext(DbContextOptions<ScraperDBContext> options) : base(options)
        {

        }

        public DbSet<User>? Users { get; set; }
    }
}
