using AutoMapper;
using EDefectiveTrade.Business.DTOs.Image;
using EDefectiveTrade.Business.Services.Interfaces;
using EDefectiveTrade.Core.Entities;
using EDefectiveTrade.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.Services.Implementations
{
    public class ProductImageService : GenericService<ProductImageDTO, ProductImage>, IProductImageService
    {
        public ProductImageService(IGenericRepository<ProductImage> genericRepository,
            IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
