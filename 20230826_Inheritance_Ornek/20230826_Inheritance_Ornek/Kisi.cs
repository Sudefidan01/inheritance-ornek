using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230826_Inheritance_Ornek
{
    internal class Kisi
    {
        public string ad, soyad, sehir;
        public string tamAd
        {
            get { return ad + " " + soyad; }
        }
    }
}
