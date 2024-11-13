using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NHL.Persistence.Models;

namespace NHL.Persistence
{
    public class NHLDbContext : DbContext
    {
        public NHLDbContext(DbContextOptions<NHLDbContext> options) : base(options)
        {
        }

        public DbSet<NHLTeam> Teams { get; set; }
        public DbSet<NHLPlayer> Players { get; set; }
        public DbSet<NHLPlayerStat> PlayersStats { get; set; }
        public DbSet<NHLGame> Games { get; set; }
        public DbSet<NHLPlayerOdds> PlayerOdds { get; set; }
        public DbSet<NHLTeamStats> TeamStats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //NHL Team
            modelBuilder.Entity<NHLTeam>().HasKey(x => x.Id);
            modelBuilder.Entity<NHLTeam>().HasMany(x => x.Stats)
                .WithOne()
                .HasForeignKey(x => x.TeamId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<NHLTeam>().Navigation(x => x.Stats).AutoInclude();
            //NHL Player
            modelBuilder.Entity<NHLPlayer>().HasKey(x => x.Id);
            modelBuilder.Entity<NHLPlayer>().HasOne(x => x.Team)
                .WithMany()
                .HasForeignKey(x => x.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<NHLPlayer>().HasMany(x => x.Stats)
                .WithOne(x => x.Player)
                .HasForeignKey(x => x.PlayerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<NHLPlayer>().HasMany(x => x.Odds)
                .WithOne()
                .HasForeignKey(x => x.PlayerId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<NHLPlayer>().Navigation(x => x.Stats).AutoInclude();
            modelBuilder.Entity<NHLPlayer>().Navigation(x => x.Odds).AutoInclude();

            //NHL Game
            modelBuilder.Entity<NHLGame>().HasKey(x => x.Id);
            modelBuilder.Entity<NHLGame>().HasOne(x => x.HomeTeam)
                .WithMany()
                .HasForeignKey(x => x.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<NHLGame>().HasOne(x => x.VisitorTeam)
                .WithMany()
                .HasForeignKey(x => x.VisitorTeamId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<NHLGame>().Navigation(x => x.HomeTeam).AutoInclude();
            modelBuilder.Entity<NHLGame>().Navigation(x => x.VisitorTeam).AutoInclude();

            //Others
            modelBuilder.Entity<NHLPlayerStat>().HasKey(x => x.Id);
            modelBuilder.Entity<NHLPlayerStat>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<NHLPlayerStat>().HasOne(x => x.OpposingTeam)
                .WithMany()
                .HasForeignKey(x => x.OpposingTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<NHLTeamStats>().HasKey(x => x.Id);
            modelBuilder.Entity<NHLPlayerOdds>().HasKey(x => x.Id);
            modelBuilder.Entity<NHLPlayerStat>().Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}