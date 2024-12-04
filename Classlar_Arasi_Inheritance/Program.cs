using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar_Arasi_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();

            kedi.isim = "Minnoş";
            kedi.kilo = "3";
            kedi.renk = "Gri";
            kedi.cinsiyet = "Dişi";
            kedi.ayakSayisi = 4;

            kedi.SesCikar();
            kedi.hayvanBilgileriGoster();

            Console.ReadLine();
        }
    }
}
