using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace EcommerceV2.Helpers
{
    public static class DataBaseHelper
    {
        public static string ConnectionValue(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}