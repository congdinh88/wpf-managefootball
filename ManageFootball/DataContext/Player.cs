using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        
    }
}
