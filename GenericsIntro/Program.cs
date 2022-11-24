using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylist<string> mylist = new Mylist<string> ();
            mylist.Add("engin");

            Console.WriteLine(mylist.Length);
            mylist.Add("ati");
            Console.WriteLine(mylist.Length);

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);

            foreach (var item in mylist.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
