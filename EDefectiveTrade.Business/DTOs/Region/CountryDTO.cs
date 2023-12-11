using EDefectiveTrade.Business.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.DTOs.Region
{
    public class CountryDTO : BaseDTO
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
    }
}
