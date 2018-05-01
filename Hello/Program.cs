using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);

            Console.WriteLine("Podaj swój wiek: ");
            int age = int.Parse(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Jesteś pełnoletni");
            }
            else
            {
                Console.WriteLine("Jesteś niepełnoletni");
            }

            Console.ReadKey();


            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj, " + item);
            //}
        }
    }
}
