using EDefectiveTrade.Business.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.DTOs.History
{
    public class ProductHistoryDTO : BaseDTO
    {
        public string Description { get; set; }
        public int ViewCount { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductCategoryId { get; set; }
    }
}
