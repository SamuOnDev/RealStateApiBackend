using Microsoft.EntityFrameworkCore;
using RealStateApiBackend.Models.DataModels;

namespace RealStateApiBackend.DataAcces
{
    public class RealStateDBContext : DbContext
    {
        public RealStateDBContext(DbContextOptions<RealStateDBContext> options) : base(options)
        {

        }

        public DbSet<User>? Users { get; set; }
        public DbSet<House>? Houses { get; set; }
    }
}
