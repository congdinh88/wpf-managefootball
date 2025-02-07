using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFootball.DataContext
{
    
    public class Match
    {
        public string Code {  get; set; }
        public DateTime Time { get; set; }
        public string Add {  get; set; }

        //Ngoại khóa tới Team1 
        public int TeamId1 {  get; set; }
        public virtual Team Team1 { get; set; }

        //Ngoại khóa tới Team2
        public int TeamId2 { get; set; }
        public virtual Team Team2 { get; set; }

        //Danh sách tới Score
        public virtual ICollection<Score> Scores { get; set; }

    }
}
