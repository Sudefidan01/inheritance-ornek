using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230826_Inheritance_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Öğrenci ve öğretmen bilgisi alacağımız bir program yapalım
            //öğretmen (üniversite , branş)
            //öğrenci (sınıf,okulNo)

            Ogretmen ogretmen= new Ogretmen();
            ogretmen.ad = "Osman";
            ogretmen.soyad = "Akkaya";
            ogretmen.sehir = "Tokat";
            ogretmen.uni = "ITU";
            ogretmen.brans = "Fizik";
            ogretmen.Yazdir();
            Console.WriteLine("--------------------");
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ad = "Kemal";
            ogrenci.soyad = "Uzun";
            ogrenci.sehir = "İzmir";
            ogrenci.sinif = 11;
            ogrenci.okulNo = 571;
            ogrenci.Yazdir();

            Console.ReadKey();
        }
    }
}
