using EDefectiveTrade.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Core.Entities
{
    public class Help : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public HelpCategory Category { get; set; }
    }
}
