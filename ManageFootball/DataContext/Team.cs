using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFootball.DataContext
{
    [Table("Teams")]
    public class Team
    {
        [Key] public int Id { get; set; }
        public string Teams { get; set; }
        
    }
}
