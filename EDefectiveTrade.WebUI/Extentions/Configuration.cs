﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace EDefectiveTrade.WebUI.Extentions
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../EDefectiveTrade.WebUI"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("SQLServerConnStr");
            }
        }
    }
}
