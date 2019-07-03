using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task5_EF.DAL.Model
{
    [Table("Supplier")]
    public class Supplier
    {       
        [Key]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierICity { get; set; }

       
        public virtual ICollection<Product> Product { get; set; }
        public Supplier()
        {
            this.Product = new List<Product>();
        }

       
    }
}
