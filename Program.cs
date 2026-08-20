using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            while (true)
            {
                Console.Write("Podaj liczbę (lub wpisz 'exit' aby zakończyć): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Koniec gry!");
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    string result = fizzBuzz.Generate(number);
                    Console.WriteLine($"Wynik: {result}");
                }
                else
                {
                    Console.WriteLine("To nie jest poprawna liczba!");
                }

                Console.WriteLine(); // pusty wiersz dla czytelności
            }
        }
    }
}
