using EDefectiveTrade.Business.DTOs.Common;
using EDefectiveTrade.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.DTOs.Region
{
    public class CityDTO : BaseDTO
    {
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}
