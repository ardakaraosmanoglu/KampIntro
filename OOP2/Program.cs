using System;

namespace OOP2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Engin Demirog
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.CustomerId = "12345";
            musteri1.Name = "Engin";
            musteri1.Surname = "Demiroğ";
            musteri1.TcNo = "22222222222";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CustomerId = "54321";
            musteri2.CompanyNo = "Kodlama.io";
            musteri2.TaxNo = "1234567890";

            // Gercek Musteri = TUzel Musteri
            // SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
