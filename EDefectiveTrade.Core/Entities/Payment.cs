using EDefectiveTrade.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Core.Entities
{
    public class Payment : BaseEntity
    {
        public decimal Payments { get; set; }
        public AnnouncementType AnnouncementType { get; set; }
    }
}
