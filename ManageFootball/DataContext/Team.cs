using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFootball.DataContext
{
    public class Team
    {
        public int Id { get; set; }
        public string Teams { get; set; }


        //Danh sách tới Match
        public virtual ICollection<Match> Matches1 { get; set; }
        public virtual ICollection <Match> Matches2 { get; set; }

        //Danh sách tới Player
        public virtual ICollection<Player> Players { get; set; }

        //Danh sách tới Score
        public virtual ICollection<Score> Scores { get; set; }
        
    }

    public class TeamConfig : EntityTypeConfiguration<Team>
    {
        public TeamConfig()
        {
            ToTable("Teams");
            HasKey(t => t.Id);
            Property(t => t.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }

    }
}
