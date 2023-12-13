using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.Services.Interfaces
{
    public interface IGenericService<TDTO, TEntity> where TDTO : class where TEntity : class
    {
        Task<TDTO> GetByIdAsync(Guid id);
        Task<IEnumerable<TDTO>> GetAllAsync();

        Task<TDTO> Create(TDTO entity);
        Task<TDTO> Update(TDTO entity);
        Task<TDTO> DeleteByIdAsync(Guid id);
    }
}
