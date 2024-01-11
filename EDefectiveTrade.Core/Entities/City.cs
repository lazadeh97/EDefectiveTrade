﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Core.Entities
{
    public class City : BaseEntity
    {
        public City()
        {
            this.Products = new List<Product>();
        }
        public string Name { get; set; }
        public Country Country { get; set; }
        public List<Product>? Products { get; set;} 
    }
}
