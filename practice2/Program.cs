using System;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 16. If-Else Statements
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            if(age >= 18)
            {
                Console.WriteLine("You're good to go.");
            }
            else
            {
                Console.WriteLine("Sorry, you aren't 18 yet.");
            }

            // 18. Switch Statements
            Console.WriteLine("Enter your year");
            int year = int.Parse(Console.ReadLine());
            switch (year)
            {
                case 1:
                {
                    Console.WriteLine("Freshman");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Sophomore");
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Junior");
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Senior");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid year");
                    break;
                }
            }

        }
    }
}
