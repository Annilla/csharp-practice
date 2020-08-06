using System;

namespace practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 32. Creating an Array
            int[] myArray = new int[3];
            myArray[0] = 5;
            myArray[1] = 6;
            myArray[2] = 7;
            
            int[] myArray2 = new int[3]{5,6,7};
            int[] myArray3 = new int[]{5,6,7};
            int[] myArray4 = {5,6,7};

            Console.WriteLine(myArray4[1]);


        }
    }
}
