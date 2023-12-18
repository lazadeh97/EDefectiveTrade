using EDefectiveTrade.Business.DTOs.ProductCategory;
using EDefectiveTrade.Business.DTOs.Region;
using EDefectiveTrade.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.Services.Interfaces
{
    public interface ICountryService : IGenericService<CountryDTO, Country>
    {
    }
}
