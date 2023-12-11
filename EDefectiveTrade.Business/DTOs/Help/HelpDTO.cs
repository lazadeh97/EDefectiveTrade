using EDefectiveTrade.Business.DTOs.Common;
using EDefectiveTrade.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.DTOs.Help
{
    public class HelpDTO : BaseDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public HelpCategory Category { get; set; }
    }
}
