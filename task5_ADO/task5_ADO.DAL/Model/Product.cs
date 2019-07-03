using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task5_ADO.DAL.Model
{
  
    public class Product
    {
       
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }    
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
     
        public virtual Supplier Supplier { get; set; }
        public int SupplierId { get; set; }      

        

    }
}
