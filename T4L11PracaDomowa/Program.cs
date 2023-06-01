using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4L11PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę całkowitą a ja powiem Ci czy jest parzysta czy nieparzysta: ");
            if (!int.TryParse(Console.ReadLine(), out int userNumber))
            {
                Console.WriteLine("Nieprawidłowe dane!");
                return;
            }

            string result = userNumber % 2 == 0 ? "Parzysta" : "Nieparzysta";

            Console.WriteLine(result);

        }
    }
}
