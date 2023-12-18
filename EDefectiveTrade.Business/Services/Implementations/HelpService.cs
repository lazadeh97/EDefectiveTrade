using AutoMapper;
using EDefectiveTrade.Business.DTOs.Help;
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
    public class HelpService : GenericService<HelpDTO, Help>, IHelpService
    {
        public HelpService(IGenericRepository<Help> genericRepository, 
            IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
