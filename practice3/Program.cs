using System;

namespace practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 24. While loops
            int total = 0;
            Console.WriteLine("Enter a number or -1 to quit.");
            int number = int.Parse(Console.ReadLine());
            while(number != -1)
            {
                total += number;
                Console.WriteLine("Enter a number or -1 to quit.");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The total is {0}.", total);

            // 25. For loop
            Console.WriteLine("Enter amount of times to print hello");
            int amount = int.Parse(Console.ReadLine());
            for(int i = 0; i < amount; i++)
            {
                Console.WriteLine("hello");
            }

            // 26. Do While loop
            string response;
            do{
                Console.WriteLine("hello");
                response = Console.ReadLine();
            } while (response == "again");

            // 27. Nested loop
            int size = 25;
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write("{0,-2}", "*");
                }
                Console.WriteLine();
            }
        }
    }
}
