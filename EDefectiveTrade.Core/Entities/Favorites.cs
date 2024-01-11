using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Core.Entities
{
    public class Favorites : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public Product? Product { get; set; }
        public AppUser? User { get; set; }
    }
}
