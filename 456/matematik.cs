using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _456
{
    class matematik
    {
        public void topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
        }

        public void topla2(int x,int sayi1=20, int sayi2=30)
        {
            int sonuc = sayi1 + sayi2+x;
            Console.WriteLine(sonuc);
        }

        public int topla3(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
