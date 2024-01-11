using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Core.Entities
{
    public class ProductHistory : BaseEntity
    {
        public ProductHistory() 
        {
            this.Products = new List<Product>();
            this.ProductCategories = new List<ProductCategory>();
        }
        public string? Description { get; set; }
        public int? ViewCount { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? ProductCategoryId { get; set; }

        public List<Product>? Products { get; set; }
        public List<ProductCategory>? ProductCategories { get; set; }

    }
}
