using MyStock.Common.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStock.Common.Helper
{
    public class HelperSettings
    {
        public static string GetConnectionString()
        {
            var isTest = GlobalSettings.Default.IsTest;
            return isTest ? GlobalSettings.Default.MyStockDbTest : GlobalSettings.Default.MyStockDb;
        }
    }
}
