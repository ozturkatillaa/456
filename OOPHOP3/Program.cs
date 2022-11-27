using System;
using System.Collections.Generic;

namespace OOPHOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            Console.WriteLine("-----------------");

            BsavuruManager bsavuruManager = new BsavuruManager();
            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();
            //bsavuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
            bsavuruManager.BasvuruYap(new TasitKrediManager(), new List<ILoggerService>() {databaseLoggerService, new fileoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() { tasitKrediManager,konutKrediManager };
            bsavuruManager.kredionbilgi(krediler);
            
            //foreach (var item in krediler)
            //{
            //    Console.WriteLine(item.Hesapla());
            //}
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
