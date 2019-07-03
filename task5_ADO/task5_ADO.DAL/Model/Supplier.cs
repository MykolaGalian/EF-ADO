using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task5_ADO.DAL.Model
{

    public class Supplier
    {       
     
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierICity { get; set; }     
       

       
    }
}
