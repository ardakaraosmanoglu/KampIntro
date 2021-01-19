using System;

namespace Metotlar
{
    public class SepetManager
    {
        //namaming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Teprikler, Sepete " + urun.Adi); 
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, double stockadedi)
        {
            Console.WriteLine("Teprikler, Sepete " + urunAdi);
        }
    }
}
