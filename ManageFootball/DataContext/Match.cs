using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFootball.DataContext
{
    [Table("Match")]
    public class Match
    {
        [Key] public string Code {  get; set; }
        public DateTime Time { get; set; }
        public string Add {  get; set; }
        public int Team_Id1 {  get; set; }
        public int Team_Id2 { get; set; }
        [ForeignKey("Team_Id1")] public virtual Team Team1 { get; set; }
        [ForeignKey("Team_Id2")] public virtual Team Team2 { get; set; }

    }
}
