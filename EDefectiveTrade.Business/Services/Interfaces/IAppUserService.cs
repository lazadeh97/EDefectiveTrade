using EDefectiveTrade.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.Services.Interfaces
{
    public interface IAppUserService 
    {
        public Task RegisterAsync(AppUser user);

        public Task<AppUser> FindUserAsync(string email, string password);
    }
}
