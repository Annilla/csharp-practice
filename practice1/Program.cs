using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Displaying Variables in the Console
            int myInt = 5;
            double myDouble = 5.5;
            string myString = "Hello World!";
            bool myBool = true;
            char myChar = 'A';

            // print single line
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.WriteLine(myString);
            Console.WriteLine(myBool);
            Console.WriteLine(myChar);

            // print next to others
            // Console.Write(myInt);
            // Console.Write(myDouble);
            // Console.Write(myString);
            // Console.Write(myBool);
            // Console.Write(myChar);

            // print with placeholder
            // {index, to fulfill spaces before placeholder}
            // positive spaces is on the left, negative spaces is on the right
            Console.WriteLine("The value of myInt is {0, -5} and the value of myDouble is {1, 5}", myInt, myDouble);

            // Print with +
            Console.WriteLine("The value of myInt is " + myInt + " and the value of myDouble is " + myDouble);

            // 4. Using Arithmetic Operators
            double myDouble2 = 45.0 / 2;
            Console.WriteLine(myDouble2);

            double remain = 5 % 4;
            Console.WriteLine(remain);

            int b1 = 4;
            int c1 = b1++;
            Console.WriteLine("The value of b is {0} and the value of c is {1}", b1, c1);

            int b2 = 4;
            int c2 = ++b2;
            Console.WriteLine("The value of b is {0} and the value of c is {1}", b2, c2);

            // 6. Using the Char Data Type
            char myChar2 = '\'';
            Console.WriteLine(myChar2);
            char myChar3 = '\n';
            Console.WriteLine(myChar3);

            // 7. Using the String Data Type
            string myString2 = "Hello \" World";
            Console.WriteLine(myString2);
        }
    }
}
