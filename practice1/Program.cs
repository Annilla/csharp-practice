using System;

namespace practice1
{
    class Program
    {
        enum DayOfWeek
        {
            SUNDAY,
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY
        }
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

            string name1 = "Jesse";
            string name2 = "Jesse";
            bool namesEqual = string.Equals(name1, name2);
            // same as
            // bool namesEqual = name1 == name2;
            Console.WriteLine("Names equal {0}", namesEqual);

            string name3 = "Jesse";
            string name4 = "Jesse";
            
            // Bob, Jesse => -1
            // Jesse, Jesse => 0
            // Jesse, Bob => 1
            int namesEqual2 = string.Compare(name3, name4);
            // same as
            // int namesEqual2 = name3.CompareTo(name4);
            Console.WriteLine("Names equal {0}", namesEqual2);
            Console.WriteLine("{0} has {1} characters", name1, name1.Length);

            string firstCharacterOfName = name1.Substring(0, 1);
            Console.WriteLine(firstCharacterOfName);
            string middleSectionOfName = name1.Substring(1, 3);
            Console.WriteLine(middleSectionOfName);

            bool startsWith = name1.StartsWith("Je");
            Console.WriteLine(startsWith);

            // 8. Numeric Conversions
            double myDouble3 = 5.5;
            int myInt2 = (int)myDouble3;
            Console.WriteLine(myInt2);

            // 9. Declaring Constants
            Console.WriteLine(Math.PI);

            DayOfWeek today = DayOfWeek.FRIDAY;
            Console.WriteLine(today);
            int numberOfToday = (int)today;
            Console.WriteLine(numberOfToday);

            // 10. Console Input
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your lastname?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}", name, lastName);

            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            number += 10;
            Console.WriteLine("The new number is {0}", number);
        }
    }
}
