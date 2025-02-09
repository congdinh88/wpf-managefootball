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
            modelBuilder.Configurations.Add(new TeamConfig());
            modelBuilder.Configurations.Add(new MatchConfig());
            modelBuilder.Configurations.Add(new PlayerConfig());
            modelBuilder.Configurations.Add(new ScoreConfig());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
