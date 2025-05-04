using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    //ממשק שמתאר את הנתונים
    public interface IContext
    {
      public DbSet<Product> Products { get; set; }
       public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public void Save();
    }
}
