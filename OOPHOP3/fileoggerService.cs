using System;

namespace OOPHOP3
{
    class fileoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("dosya log");
        }
    }
}
