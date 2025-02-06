using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFootball.DataContext
{
    [Table("Scores")]
    public class Score
    {
        [Key] public int id {  get; set; }
        public int score { get; set; }
        public string Match_Code { get; set; }
        public virtual Match Match { get; set; }
        public int Team_id {  get; set; }
        public virtual Team Team { get; set; }

    }
}
