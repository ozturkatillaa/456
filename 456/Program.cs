using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _456
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(20);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            //Console.WriteLine(Multiply(2, 4));
            //Console.WriteLine(Multiply(2, 4, 5));

            //Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));

            //Console.ReadLine();

            //ternary oparator ?
            //Console.Write("[1-10] arasında sayı giriniz :");
            //int sayi = int.Parse(Console.ReadLine());
            //string cevap = "";
            //cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";


            //Console.WriteLine(cevap);
            //Console.ReadLine();

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi1 = Int32.Parse(Console.ReadLine());

            //switch (sayi1)
            //{

            //    case 1: Console.WriteLine("Pazartesi"); break;
            //    case 2: Console.WriteLine("Salı"); break;
            //    case 3: Console.WriteLine("Çarşamba"); break;
            //    case 4: Console.WriteLine("Perşembe"); break;
            //    case 5: Console.WriteLine("Cuma"); break;
            //    case 6: Console.WriteLine("Cumartesi"); break;
            //    case 7: Console.WriteLine("Pazar"); break;

            //    default: Console.WriteLine("Hata Böyle bir gün yok"); break;
            //}

            //Console.ReadLine();

            //Console.WriteLine("Lütfen bir gün giriniz");
            //string gun = Console.ReadLine();

            //switch (gun)
            //{

            //    case "pazartesi": Console.WriteLine("Hafta içi"); break;
            //    case "salı": Console.WriteLine("Hafta içi"); break;
            //    case "çarşamba": Console.WriteLine("Hafta içi"); break;
            //    case "perşembe": Console.WriteLine("Hafta içi"); break;
            //    case "cuma": Console.WriteLine("Hafta içi"); break;
            //    case "cumartesi": Console.WriteLine("Hafta sonu"); break;
            //    case "pazar": Console.WriteLine("Hafta sonu"); break;
            //    default: Console.WriteLine("Böyle bir gün yok! hafta içi veya hafta sonu olduğu bulunamaz"); break;
            //}

            urun urun1 = new urun();
            urun1.fiyat = 50;
            urun1.isim = "iphone";
            urun1.magaza = "hepsiburada";

            urun urun2 = new urun();
            urun2.fiyat = 30;
            urun2.isim = "samsung";
            urun2.magaza = "hepsiburada";


            urun[] urunler = new urun[] { urun1, urun2 };

            foreach (var uruns in urunler)
            {
                Console.WriteLine(uruns.isim);
            }

            for (int tek = 0; tek < urunler.Length; tek++)
            {
                Console.WriteLine(urunler[tek].isim+urunler[tek].magaza);
            }

            int i = 0;
            while (i < urunler.Length)
            {
                Console.WriteLine(urunler[i].isim);
                i++;
            }


            Console.ReadLine();


            //int i = 1;
            //while (i <= 100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (var i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
        }
        //static void Add()
        //{
        //    Console.WriteLine("Added!!!");
        //}
        //static int Add2(int number1, int number2=30)
        //{
        //    var result = number1 + number2;
        //    return result;
        //}

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
            //}
            //static int Multiply(int number1, int number2)
            //{
            //    return number1*number2;
            //}
            //static int Multiply(int number1, int number2, int number3)
            //{
            //    return number1 * number2 * number3 ;
            //}

            //static int Add4(params int[] numbers)
            //{
            //    return numbers.Sum() ;
            //} 

        }
    }
}
