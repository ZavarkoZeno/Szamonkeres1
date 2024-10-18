using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamonkeres1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a pontszámot (1-100):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int pontszam))
            {
                if (pontszam >= 0 && pontszam <= 49)
                {
                    Console.WriteLine("Elégtelen");
                }
                else if (pontszam >= 50 && pontszam <= 59)
                {
                    Console.WriteLine("Elégséges");
                }
                else if (pontszam >= 60 && pontszam <= 79)
                {
                    Console.WriteLine("Közepes");
                }
                else if (pontszam >= 80 && pontszam <= 89)
                {
                    Console.WriteLine("Jó");
                }
                else if (pontszam >= 90 && pontszam <= 100)
                {
                    Console.WriteLine("Jeles");
                }
                else if (pontszam < 0 || pontszam > 100)
                {
                    Console.WriteLine("Érvénytelen pontszám");
                }
            }
            else
            {
                Console.WriteLine("Érvénytelen pontszám");
            }
        }
    }
}
