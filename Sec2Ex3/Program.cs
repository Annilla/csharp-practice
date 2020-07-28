using System;

namespace Sec2Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess one number from 1 to 10");
            int guess = int.Parse(Console.ReadLine());
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            if(randomNumber > guess)
            {
                Console.WriteLine("{0} > {1}. It's too low.", randomNumber, guess);
            }
            else if(randomNumber < guess)
            {
                Console.WriteLine("{0} < {1}. It's too high.", randomNumber, guess);
            }
            else if(randomNumber == guess)
            {
                Console.WriteLine("{0} = {1}. It's correct.", randomNumber, guess);
            }
        }
    }
}
