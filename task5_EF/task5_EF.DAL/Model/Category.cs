using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_EF.DAL.Model
{
    [Table("Category")]
    public class Category
    {

        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

       
        public virtual ICollection<Product> Product { get; set; }
        public Category()
        {
            this.Product = new List<Product>();
        }

        
    }
}
