using System;

namespace ukol_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej rok:");
            int rok = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(rok))
            {
                Console.WriteLine("Rok je prestupny");
            }
            else
            {
                Console.WriteLine("Rok neni prestupny");
            }
            Console.ReadKey();
        }
    }
}
