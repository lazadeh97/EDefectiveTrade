﻿using EDefectiveTrade.Core.Entities;
using EDefectiveTrade.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.DTOs.Product
{
    internal class SaveProductDto
    {
        public SaveProductDto()
        {
            this.Images = new List<ProductImage>();
        }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Guid? ProductCategoryId { get; set; }
        public List<ProductImage> Images { get; set; }
        public AnnouncementType AnnouncementType { get; set; }
    }
}
