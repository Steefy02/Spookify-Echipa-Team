using Microsoft.EntityFrameworkCore;
using Service.Backend.Entity;

namespace Service.Backend.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Stats> Stats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("conn string");
        }
    }
}
