﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_EF.DTO
{
   
    public class CategoryDTO
    {
        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }   
        
    }
}
