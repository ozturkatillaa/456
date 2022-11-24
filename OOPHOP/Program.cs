using System;
using System.Collections.Generic;

namespace OOPHOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product() {Id=2,CategoryId=5,ProductName="kalem",
                UnitPrice=5,UnitInStock=1 };


            List<string> isimler = new List<string> { "ali", "ayse" };
            isimler.Add("ati");
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);


        }
    }
}
