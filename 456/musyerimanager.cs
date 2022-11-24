using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _456
{
    class musyerimanager
    {
        public string ekle (musteri musteris)
            
        {
            return musteris.adı+musteris.soyadı+"eklendi";

        }
        public void listele(musteri musteris)

        {
            Console.WriteLine(musteris.adı+"\n"+ musteris.soyadı + "\n" + musteris.sehir + "\n" +musteris.id);

        }

        public void sil(musteri musteris)
        {
            Console.WriteLine(musteris.soyadı+"silindi");
        }



    }
}
