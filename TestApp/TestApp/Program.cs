using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine(":-)");
            
            double a;
            Boolean weiter = true;

            while (weiter)
            {
                Console.WriteLine("Bitte 1 eingeben");
                a = Convert.ToDouble(Console.ReadLine());

                if (a == 1)
                {
                    Console.WriteLine("Korrekte Eingabe");
                }
                else
                {
                    Console.WriteLine("Fehler: Eingabe");
                }

                Console.WriteLine("Weiter mit 'w': ");
                weiter = Console.ReadLine().Equals("w");
            }
            Console.ReadKey();
        }
    }
}
