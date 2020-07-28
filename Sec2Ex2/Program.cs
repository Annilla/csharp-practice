using System;

namespace Sec2Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lawn length");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter lawn width");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            double fee = 0;
            if(area < 400)
            {
                fee = 25.0;
            }
            else if(area >= 400 || area < 600)
            {
                fee = 35.0;
            }
            else if(area >= 600)
            {
                fee = 50.0;
            }
            double total = fee * 20;
            Console.WriteLine("Weekly mowing fee is ${0} and total fee for the 20-week season is ${1} ", fee, total);

        }
    }
}
