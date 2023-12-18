using EDefectiveTrade.Core.Entities;
using EDefectiveTrade.Core.Interfaces;
using EDefectiveTrade.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Data.Implementations
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
