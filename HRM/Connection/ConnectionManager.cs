using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Connection
{
    public static class ConnectionManager
    {
        public static string? ConnectionString { get => ConfigurationManager.AppSettings["dbConnection"]; }

        
    }
}
