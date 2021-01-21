using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();

            isimler.Add("Gürkan");
            isimler.Add("Engin");
            Console.WriteLine(isimler.Length); //Test
            isimler.Add("Ahmet");
            isimler.Add("Murat");
            Console.WriteLine(isimler.Length); //Test
        }
    }
}
