using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4L13PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra FizzBuzz:\n" +
                "-Jeśli Twoja liczba jest podzielna przez 3 - zwracamy Fizz\n" +
                "-Jeśli Twoja liczba jest podzielna przez 5 - zwracamy Buzz\n" +
                "-Jeśli Twoja liczba jest podzielna przez 3 i 5 - zwracamy FizzBuzz\n" +
                "-Jeśli Twoja liczba nie jest podzielna przez 3 lub 5 - zwracamy liczbę.");

            while (true)
            {
                Console.Write("Podaj liczbę: ");
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                {
                    Console.WriteLine("Nieprawidłowe dane, kolego");
                    continue;
                }

                Console.WriteLine(CheckTheNumber(userNumber)); 
                AgainOfExit();
            }

        }

        private static string CheckTheNumber(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return"Fizz";
            }
            else if (number % 5 == 0)
            {
                return"Buzz";
            }
            else
            {
                return number.ToString();
            }
        }

        private static void AgainOfExit()
        {
            Console.WriteLine("Jeśli chcesz opuścić program, wpisz T:");
            string val = Console.ReadLine();
            if (val.ToLower() == "t")
            {
                Environment.Exit(0);
            }
        }
    }
}
