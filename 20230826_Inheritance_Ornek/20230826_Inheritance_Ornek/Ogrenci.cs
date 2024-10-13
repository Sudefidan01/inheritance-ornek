using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230826_Inheritance_Ornek
{
    internal class Ogrenci:Kisi
    {
        public int sinif, okulNo;

        public new void Yazdir()
        {
            Console.WriteLine("Öğrenci Bilgileri");
            Console.WriteLine("-------------------");
            Console.WriteLine("Öğrencinin Adı ve Soyadı : " + tamAd);
            Console.WriteLine("Öğrencinin Memleketi : " + sehir);
            Console.WriteLine("Öğrencinin Sınıfı : " +sinif);
            Console.WriteLine("Öğrencinin Okul Numarası : " +okulNo);
        }
    }
}
