using System;
namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyac kredisi ödeme planı hesaplandı.");
        }
    }
}
