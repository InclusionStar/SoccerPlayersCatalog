using Microsoft.EntityFrameworkCore;

namespace SoccerPlayersCatalog.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Gender> Genders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            Database.EnsureDeleted();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Россия"},
                new Country { Id = 2, Name = "США"},
                new Country { Id = 3, Name = "Италия"}
            );

            modelBuilder.Entity<Gender>().HasData(
                new Gender { Id = 1, Name = "Мужской" },
                new Gender { Id = 2, Name = "Женский" }
            );
        }
    }
}