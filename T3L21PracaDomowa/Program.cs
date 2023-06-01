using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3L21PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Podaj imię: ");
                var name = Console.ReadLine();

                Console.Write("Podaj miejsce urodzenia: ");
                var city = Console.ReadLine();

                Console.Write("Podaj datę urodzenia (DD.MM.RRRR): ");

                if (!DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
                {
                    Console.WriteLine("Nieprawidłowe dane.");
                    return;
                }

                var years = DateTime.Now.DayOfYear < birthDate.DayOfYear ? DateTime.Now.Year - birthDate.Year - 1 : DateTime.Now.Year - birthDate.Year;

                Console.WriteLine($"Cześć {name}! Urodziłeś się w {city} i masz {years} lat.");
                Console.ReadKey();

        }
    }
}
