using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHOP3
{
    class BsavuruManager
    {

        //method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerService)
        {
            krediManager.Hesapla();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }

        public void kredionbilgi(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
