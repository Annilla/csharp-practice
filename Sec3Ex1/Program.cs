using System;

namespace Sec3Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double pay;
            do {
                Console.WriteLine("Enter an hour pay rate");
                pay = double.Parse(Console.ReadLine());
            } while(pay < 5.65 || pay > 49.99);
        }
    }
}
