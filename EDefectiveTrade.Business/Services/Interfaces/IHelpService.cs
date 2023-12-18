using EDefectiveTrade.Business.DTOs.Help;
using EDefectiveTrade.Business.DTOs.ProductCategory;
using EDefectiveTrade.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.Services.Interfaces
{
    public interface IHelpService : IGenericService<HelpDTO, Help>
    {
    }
}
