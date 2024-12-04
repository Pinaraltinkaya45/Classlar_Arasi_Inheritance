using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar_Arasi_Inheritance
{
    public class Kedi : Kopek
    {
        public void SesCikar()
        {
            Console.WriteLine("Kedi Ses Çıkarıyor..");
        }

        public void hayvanBilgileriGoster()
        {
            Console.WriteLine("Hayvan ismi : " + isim);
            Console.WriteLine("Hayvan rengi : " + renk);
            Console.WriteLine("Hayvan kilo : " + kilo);
            Console.WriteLine("Hayvan ayak sayısı : " + ayakSayisi);
            Console.WriteLine("Hayvanın cinsiyeti : " + cinsiyet);
        }

    }
}
