using AutoMapper;
using EDefectiveTrade.Business.DTOs.Product;
using EDefectiveTrade.Business.Services.Interfaces;
using EDefectiveTrade.Core.Entities;
using EDefectiveTrade.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.Services.Implementations
{
    public class ProductService : GenericService<ProductDTO, Product>, IProductService
    {
        public ProductService(IGenericRepository<Product> genericRepository,
            IMapper mapper): base(genericRepository, mapper)
        {
        }
    }
}
