using EDefectiveTrade.Business.Services.Implementations;
using EDefectiveTrade.Business.Services.Interfaces;
using EDefectiveTrade.Core.Interfaces;
using EDefectiveTrade.Data.DAL;
using EDefectiveTrade.Data.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.WebUI.Extentions
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services) 
        {
            services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(Configuration.ConnectionString));



            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));

            services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddScoped<IProductCategoryService, ProductCategoryService>();
        }
    }
}
