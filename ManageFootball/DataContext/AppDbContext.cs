using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFootball.DataContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() : base("name=DefaultConnection")
        {
        }
    }
}
