using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageFootball.DataContext;

namespace ManageFootball.Models
{
    public class ScoreModel
    {
        public int Id { get; set; }
        public string MatchCode { get; set; }
        public int TeamId { get; set; }
        public int Sco { get; set; }
    }
}
