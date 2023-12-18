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
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
