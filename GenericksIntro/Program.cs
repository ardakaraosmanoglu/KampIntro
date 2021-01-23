using System;

namespace GenericksIntro
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Arda");

            Console.WriteLine("Hello World!");
        }
    }
}
