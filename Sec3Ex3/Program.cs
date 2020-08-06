using System;

namespace Sec3Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1,11);
            int guess;

            do {
                Console.WriteLine("Guess number");
                guess = int.Parse(Console.ReadLine());
                if(guess > randomNumber) {
                    Console.WriteLine("Your guess {0} is too high", guess);
                } else if(guess < randomNumber) {
                    Console.WriteLine("Your guess {0} is too low", guess);
                } else {
                    Console.WriteLine("Your guess {0} is correct", guess);
                }
            } while(guess != randomNumber);
        }
    }
}
