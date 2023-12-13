using EDefectiveTrade.Business.DTOs.ProductCategory;
using EDefectiveTrade.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.Services.Interfaces
{
    public interface IProductCategoryService:IGenericService<ProductCategoryDTO,ProductCategory>
    {
    }
}
