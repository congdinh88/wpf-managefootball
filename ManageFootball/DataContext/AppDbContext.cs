using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ManageFootball.DataContext
{
    public class AppDbContext:DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matchs { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Player> Player { get; set; }
        public AppDbContext() : base("name=DefaultConnection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Cấu hình bảng Team
            modelBuilder.Entity<Team>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Team>()
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Cấu hình bảng Match
            modelBuilder.Entity<Match>()
                .HasKey(t => t.Code);
            //Thiết lập mối quan hệ với bảng Team
            modelBuilder.Entity<Match>()
                .HasRequired(m => m.Team1)
                .WithMany(t => t.Matches1)
                .HasForeignKey(m => m.TeamId1)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Match>()
                .HasRequired(m => m.Team2)
                .WithMany(t => t.Matches2)
                .HasForeignKey(m => m.TeamId2)
                .WillCascadeOnDelete(false);

            // Cấu hình bảng Player
            modelBuilder.Entity<Player>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Player>()
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            // Thiết lập mối quan hệ với bảng Team
            modelBuilder.Entity<Player>()
                .HasRequired(t => t.Team)
                .WithMany(m => m.Players)
                .HasForeignKey(m => m.TeamId)
                .WillCascadeOnDelete(false);

            // Cấu hình bảng Score
            modelBuilder.Entity<Score>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Score>()
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            // Thiết lập mối quan hệ với bảng Match
            modelBuilder.Entity<Score>()
                .HasRequired(t => t.Match)
                .WithMany(m => m.Scores)
                .HasForeignKey(m => m.MatchCode)
                .WillCascadeOnDelete (false);
            // Thiết lâp mối quan hệ với bảng Team
            modelBuilder.Entity<Score>()
                .HasRequired(t => t.Team)
                .WithMany(m => m.Scores)
                .HasForeignKey(m => m.Team)
                .WillCascadeOnDelete(false);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
