using System;

namespace Sec1Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter miniutes only");
            int minutes = int.Parse(Console.ReadLine());
            int hour = minutes / 60;
            int min = minutes % 60;
            Console.WriteLine("{0} minutes = {1} hour + {2} minutes", minutes, hour, min);
        }
    }
}
