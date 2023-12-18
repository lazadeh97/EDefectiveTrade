using AutoMapper;
using EDefectiveTrade.Business.DTOs.ProductCategory;
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
    public class ProductCategoryService : GenericService<ProductCategoryDTO, ProductCategory>, IProductCategoryService
    {
        public ProductCategoryService(IGenericRepository<ProductCategory> genericRepository,
            IMapper mapper
            //, 
            //ILogger<GenericService<ProductCategoryDTO,
            //    ProductCategory>> logger
            )
            : base(genericRepository, mapper
                  //, logger
                  )
        {
        }
    }
}
