using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFootball.DataContext.Model
{
    public class MatchModel
    {
        public string Code { get; set; }
        public DateTime Time { get; set; }
        public string Addresse { get; set; }
        public int TeamId1 { get; set; }
        public int TeamId2 { get; set; }

    }
}
