using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task5_ADO.DTO
{

    public class SupplierDTO
    {      
      
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierICity { get; set; }     

       
    }
}
