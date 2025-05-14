using AcunMedyaSportsProject.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaSportsProject.WebApi.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Team> Teams  { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchSet> MatchSets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MatchSet>().HasKey(x=> new { x.MatchId, x.SetNumber });
            modelBuilder.Entity<Match>()
                .HasOne(y => y.HomeTeam)
                .WithMany(x => x.HomeTeamMatches)
                .HasForeignKey(x => x.HomeTeamId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Match>()
                .HasOne(y => y.AwayTeam)
                .WithMany(x => x.AwayTeamMatches)
                .HasForeignKey(x => x.AwayTeamId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }

    }
}
