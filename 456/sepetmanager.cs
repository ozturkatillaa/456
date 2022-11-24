using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _456
{
    class sepetmanager
    {
        public void ekle(product uruns) 
        {
            
            Console.WriteLine("basarıyl eklendi"+ uruns.adi);
        }

        public void ekle2(string isim,string acıklma,int fiyat,int stok)
        {
            Console.WriteLine("urunu eklendi,ismi:"+isim);        }
    }
}
