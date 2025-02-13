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
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number {  get; set; }

        //Ngoại khóa tới Team
        public int TeamId {  get; set; }
        public virtual Team Team { get; set; }

        public virtual ICollection<Stats> Stats { get; set; }

    }
    public class PlayerConfig : EntityTypeConfiguration<Player>
    {
        public PlayerConfig()
        {
            ToTable("Players");
            HasKey(t => t.Id);
            Property(t => t.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(m => m.Team)
            .WithMany(t => t.Players)
            .HasForeignKey(m => m.TeamId)
            .WillCascadeOnDelete(false);
        }

    }
}
