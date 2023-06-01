using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3L22PracaDomowa
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfTries = 0;
            Random random = new Random();
            var properNumber = random.Next(0, 100);

            while (true)
            {
                Console.WriteLine("Wybierz liczbę: ");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Nieprawidłowe dane!");
                    continue;
                }

                if (number < properNumber)
                {
                    numberOfTries++;
                    Console.WriteLine("Za mało, spróbuj jeszcze raz.");
                    continue;
                }

                else if (number > properNumber)
                {
                    numberOfTries++;
                    Console.WriteLine("Za dużo, spróbuj jeszcze raz.");
                    continue;
                }

                else
                {
                    numberOfTries++;
                    Console.WriteLine($"BRAWO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! Udało sie w {numberOfTries} próbach.");
                    return;
                }
            }

        }
    }
}
