using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_EF.DAL.Model
{
    public class ProdDbContext : DbContext
    {
        public ProdDbContext() : base("ProdConection")    {  }
        

        public virtual DbSet<Category> Category_ { get; set; }
        public virtual DbSet<Product> Product_ { get; set; }
        public virtual DbSet<Supplier> Supplier_ { get; set; } 
    }
}
