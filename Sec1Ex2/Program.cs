using System;

namespace Sec1Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sec1 Ex2
            Console.WriteLine("The length of your room?");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("The width of your room?");
            double width = double.Parse(Console.ReadLine());
            const double price = 5.50;
            Console.WriteLine("The price of carpeting per square foot is {0}", price);
            double cost = length * width * price;
            Console.WriteLine("The cost of carpeting the room is {0}", cost);
        }
    }
}
