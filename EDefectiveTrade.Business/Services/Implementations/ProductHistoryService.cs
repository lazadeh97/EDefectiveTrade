using AutoMapper;
using EDefectiveTrade.Business.DTOs.History;
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
    public class ProductHistoryService : GenericService<ProductHistoryDTO, ProductHistory>,
        IProductHistoryService
    {
        public ProductHistoryService(IGenericRepository<ProductHistory> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
