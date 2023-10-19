using System;
namespace Uppgift4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            //------------------------

            bool sign1Exists = false;
            bool sign2Exists = false;
            
            Console.WriteLine("Skriv in en valfri sträng:");
            string userString = Console.ReadLine().ToLower();

            Console.WriteLine("Skriv in två tecken:");
            string signs = Console.ReadLine().ToLower();

            char sign1 = signs[0];
            char sign2 = signs[1];

            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] == sign1)
                {
                    sign1Exists = true;
                }
                else if (userString[i] == sign2)
                {
                    sign2Exists = true;
                }
            }

            if (sign1Exists && sign2Exists)
            {
                Console.WriteLine($"Både {sign1} och {sign2} finns med i {userString}.");
            }
            else if (sign1Exists)
            {
                Console.WriteLine($"Det finns minst ett {sign1} med i {userString}.");
            }
            else if (sign2Exists)
            {
                Console.WriteLine($"Det finns minst ett {sign2} med i {userString}.");
            }
            else
            {
                Console.WriteLine($"Varken ett {sign1} eller ett {sign2} finns med i {userString}.");
            }
        }
    }
}