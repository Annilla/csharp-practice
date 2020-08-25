using System;

namespace Sec4Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Set a word.
            string[] word = {"A", "n", "n", "y"};
            int win = 0;
            string letter;

            do {
                // 2. Guess a Letter.
                Console.WriteLine("Guess a letter");
                letter = Console.ReadLine();
                // 3. If guess right, show letters in word and message.
                
                // 4. If guess wrong, show error message.
            } while (win != word.Length);
            // 5. If all letters are shown, show win message.
        }
    }
}
