using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterpriseManagement.Utilities
{
    public static class ProductLogger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"[LOG - {DateTime.Now}] {message}");
        }
    }
}
