﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_EF.DTO
{
    public class ViewProductDTO
    {
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }

    }
}