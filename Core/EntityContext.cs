using Core.Models.Database;
using Microsoft.EntityFrameworkCore;
using System;

namespace Core
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>().HasData(new Match[]
            {
                new Match
                {
                    StartDateTime = DateTime.Now.AddMinutes(10),
                    MatchLength = 60
                },
                new Match
                {
                    StartDateTime = DateTime.Now.AddMinutes(12),
                    MatchLength = 60
                },
                new Match
                {
                    StartDateTime = DateTime.Now.AddMinutes(14),
                    MatchLength = 60
                },
                new Match
                {
                    StartDateTime = DateTime.Now.AddMinutes(16),
                    MatchLength = 60
                },
                new Match
                {
                    StartDateTime = DateTime.Now.AddMinutes(18),
                    MatchLength = 60
                }
            });
        }

        public DbSet<Match> Matches { get; set; }
        public DbSet<UserMatchResult> UserMatchResults { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
