using System;

// Rekursiv metodlar. Faktorialın rekursiya vasitəsilə aşkar edilməsi.

namespace MethodsRecFact
{

    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        static void Main()
        {
            int factorial = Factorial(5);

            Console.WriteLine(factorial);

            // Delay.
            Console.ReadKey();
        }
    }
}
