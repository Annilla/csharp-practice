using System;

namespace Sec4Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zipArray = new int[10]{ 111, 222, 333, 444, 555, 666, 777, 888, 999, 000 };

            string[] compArray = new string[10]{ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

            Console.WriteLine("Enter zip code");
            int code = int.Parse(Console.ReadLine());
            bool found = false;

            for(int i = 0; i < zipArray.Length; i++) {
                if(code == zipArray[i]) {
                    Console.WriteLine("Zip {0} is company {1}.", code, compArray[i]);
                    found = true;
                    break;
                }
            }

            if(!found) {
                Console.WriteLine("Zip {0} is not found.", code);
            }
        }
    }
}
