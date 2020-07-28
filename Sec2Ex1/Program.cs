using System;

namespace Sec2Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hourly pay rate");
            double rate = double.Parse(Console.ReadLine());
            if(rate < 7.5 || rate > 49.0)
            {
                Console.WriteLine("Invalid rate.");
            }
            else
            {
                Console.WriteLine("The rate is ok.");
            }
        }
    }
}
