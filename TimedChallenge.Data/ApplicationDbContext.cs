using Microsoft.EntityFrameworkCore;
using TimedChallenge.Data.Entities;

public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {

        }
        public DbSet<PostEntity> Posts { get; set; }
    }


