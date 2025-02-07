using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFootball.DataContext
{
    public class Score
    {
        public int Id {  get; set; }

        //Ngoại khóa tới Match
        public string MatchCode { get; set; }
        public virtual Match Match { get; set; }

        //Ngoại khóa tới Team
        public int TeamId {  get; set; }
        public virtual Team Team { get; set; }

        public int Sco { get; set; }


    }
}
