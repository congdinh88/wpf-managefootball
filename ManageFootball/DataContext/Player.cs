using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFootball.DataContext
{
    [Table("Players")]
    public class Player
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public int Number {  get; set; }
        public int TeamId {  get; set; }
        [ForeignKey("TeamId")] public virtual Team Team { get; set; }
        
    }
}
