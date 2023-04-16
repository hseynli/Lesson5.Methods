using System;

// Metodların overload olunması. 

namespace Methods
{
    class Program
    {
        static void Operation()                                         // 1-ci overloading.
        {
            Operation("val", 10, 12.2);
        }

        static void Operation(string value1)                            // 2-ci overloading.
        {
            Operation(value1, 10, 12.2);
        }

        static void Operation(string value1, int value2)                // 3-cü overloading.
        {
            Operation(value1, value2, 12.2);
        }

        static void Operation(string value1, int value2, double value3) // 4-cü overloading.
        {
            Console.WriteLine("{0},{1},{2}", value1, value2, value3);
        }

        static void Main()
        {
            Operation();                  // 1-ci overloading.
            Operation("val");             // 2-ci overloading.
            Operation("val", 10);         // 3-cü overloading. 
            Operation("val", 10, 12.2);   // 4-cü overloading.

            // Delay.
            Console.ReadKey();
        }
    }
}
