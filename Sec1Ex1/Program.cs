using System;

namespace Sec1Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sec1 Ex1
            Console.WriteLine("Enter first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = int.Parse(Console.ReadLine());
            int total = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, total);
        }
    }
}
