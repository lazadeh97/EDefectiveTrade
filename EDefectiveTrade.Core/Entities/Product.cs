﻿using EDefectiveTrade.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Core.Entities
{
    public class Product:BaseEntity
    {
        public Product()
        {
            this.Images = new List<ProductImage>();
        }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Guid? ProductCategoryId { get; set; }
        public City? City { get; set; }
        public AppUser? User { get; set; }
        public ProductCategory? ProductCategory { get; set; }
        public List<ProductImage>? Images { get; set; }
        public AnnouncementType AnnouncementType { get; set; }
    }
}
