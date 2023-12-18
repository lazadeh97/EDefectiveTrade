using EDefectiveTrade.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Data.Configurations
{
    public class HelpConfiguration : IEntityTypeConfiguration<Help>
    {
        public void Configure(EntityTypeBuilder<Help> builder)
        {
            throw new NotImplementedException();
        }
    }
}
