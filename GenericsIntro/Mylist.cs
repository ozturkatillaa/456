using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class Mylist<T>
    {
        //string[] items  T DEDİĞMİZ GENERİC TİPLER STRİNG VS;
        T[] items;
        //CONSTRUCTOR , BİR ARRAYNEWLENDİĞİ ZAMAN CONSTRUCTOR DENİR
        //YANİ ŞUNU YAPIYOR DİYELİM Kİ STRİNG
        // STRİNG[] İTEMS = NEW STRİNG[0] ARTIK SIFIR ELEMANLI DİZMİZ VAR VE BAŞKA DEĞER EKLEYEBİLİRZ
        public Mylist()
        {
            items = new T[0]; 
        }
        public void Add(T item) //ADD İÇERSİNDE İTEMS ELEMANLARI EKLEMEK İSTİYOR, EKLEYEBİLMEK İÇİN BİR ARRAYİN NEWLENME ZORUNLULUĞU VAR
        {
            T[] tempArray = items;//bunu yapmamızın sebebi, aşagıda eleman sayısını arttırdık ama bunu yaptığımızda referans tipi unutuluyor, boş geşir, buraya geçci olarak atadık.
            items = new T[items.Length+1];//+1 yer açtık

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//temparray içinde tutugumuz değerlri geri yeni arraya atadık ve son eklenen elemanı son indekse koyduk
            }

            items[items.Length - 1] = item;

        }

        public int Length {

            get { return items.Length; }
            
            }
        public T[] Items //items tüm atanan elemanlarını çağırma
        {

            get { return items; }

        }

    }
}
