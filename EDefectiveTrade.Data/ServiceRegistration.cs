using EDefectiveTrade.Data.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Data
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services) 
        {
            services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(Configuration.ConnectionString,
                    providerOptions => providerOptions.EnableRetryOnFailure()));
        }
    }
}
