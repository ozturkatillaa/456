using System;

namespace OOPHOP2
{
    class Program
    {
        static void Main(string[] args)
        {


            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adı = "ATİ";
            musteri1.Soyadı = "OZT";
            musteri1.Id = 52;
            musteri1.TcNo = "6587896";
            
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.VergiNo = "54545";
            musteri2.SirketAdı = "?";
            

            Musteri musteri3 = new GercekMusteri();
            musteri3.Id = 53;
            musteri3.MusteriNo = "896";
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            


            Console.WriteLine("Hello World!");
            Console.ReadLine();
            
        }
    }
}
