using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageFootball.DataContext;

namespace ManageFootball.Models
{
    public class StatsModel
    {
        public int Id { get; set; }
        public string MatchCode { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public bool? YellowCard { get; set; }
        public bool? RedCard { get; set; }
        public bool? Goals { get; set; }
        public string Time { get; set; }
    }
}
