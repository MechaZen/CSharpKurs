using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ;)
            {
                Powitanie();
                Wiek();
                Koniecpętli();
            }
        }

        /// <summary>
        /// Czyścimy ekran, i witamy kolejną osobę.
        /// </summary>
        private static void Koniecpętli()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Prosimy, o podanie wieku przez gościa.
        /// </summary>
        private static void Wiek()
        {
            Console.Write("Podaj swój wiek: ");

            int age;
            bool wynik = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jesteś pełnoletni.");
            }

            else if (wynik == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Zły format danych. Wpisz prawidłowy.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jesteś niepełnoletni.");
            }
        }

        /// <summary>
        /// Co tu dużo pisać, witamy się z gościem :-)
        /// </summary>
        private static void Powitanie()
        {
            Console.Write("Podaj swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }
    }
}
