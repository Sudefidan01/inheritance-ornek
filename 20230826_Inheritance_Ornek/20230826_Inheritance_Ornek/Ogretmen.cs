using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230826_Inheritance_Ornek
{
    internal class Ogretmen:Kisi
    {
        public string uni, brans;

        public void Yazdir()
        {
            Console.WriteLine("Öğretmen Bilgileri");
            Console.WriteLine("-------------------");
            Console.WriteLine("Öğretmenin Adı ve Soyadı : "+tamAd);
            Console.WriteLine("Öğretmenin Memleketi : "+sehir);
            Console.WriteLine("Öğretmenin Mezun Olduğun Üniversite : "+uni);
            Console.WriteLine("Öğretmenin Branşı : "+brans);
        
        }
    }
}
