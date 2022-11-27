using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("database log");
        }
    }
}
