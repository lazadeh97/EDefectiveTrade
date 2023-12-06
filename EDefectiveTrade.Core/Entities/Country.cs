using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Core.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
    }
}
