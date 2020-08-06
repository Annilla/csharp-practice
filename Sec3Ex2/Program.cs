using System;

namespace Sec3Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 51; i++) {
                sum = sum + i;
            }
            Console.WriteLine("Total is {0}", sum);
        }
    }
}
