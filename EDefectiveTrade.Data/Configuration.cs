using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace EDefectiveTrade.Data
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationBuilder builder = new ConfigurationBuilder();
                // Cari kataloqa olan yolu göstərmək
                builder.SetBasePath(Directory.GetCurrentDirectory());
                // Konfiqurasiyanı appsettings.json faylından əldə etmək
                builder.AddJsonFile("appsettings.json");
                // Konfiqurasiyanı yaradırıq
                IConfigurationRoot config = builder.Build();
                // Connection stringi əldə edirik
                return config.GetConnectionString("SQLServerConnStr");
            }
        }
    }
}
