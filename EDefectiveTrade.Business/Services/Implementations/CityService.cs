using AutoMapper;
using EDefectiveTrade.Business.DTOs.Region;
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
    public class CityService : GenericService<CityDTO, City>, ICityService
    {
        public CityService(IGenericRepository<City> genericRepository,
            IMapper mapper): base(genericRepository, mapper)
        {
        }
    }
}
