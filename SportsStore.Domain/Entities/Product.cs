﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace SportsStore.Domain.Entities
{
    public class Product 
    { 
        public int ProductID { get; set; } 
        public string Name { get; set; } 
        public string Description { get; set; } 
        public decimal Price { get; set; } 
        public string Category { get; set; }

        public Product()
        {
            Logger.Info("in Product()", "class Product");
        }
    }
}
