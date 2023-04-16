using System;

// Metodların overload (yüklənməsi) olunması. 

namespace Methods
{
    class Program
    {
        // Overload olunmuş metodlar tip və arqument sayına, həmçinin ref, out və in parametr tiplərinə görə fərqlənə bilər. 
        // Eyni zamanda ref, out və in overload yaratmaq olmaz!

        static void Function()                 // 1-ci overloading.   
        {
            Console.WriteLine("Hello!");
        }

        static void Function(string s)         // 2-ci overloading.
        {
            Console.WriteLine(s);
        }

        static void Function(int i)            // 3-cü overloading.
        {
            Console.WriteLine(i);
        }

        static void Function(double d)         // 4-cü overloading.
        {
            Console.WriteLine(d);
        }

        static void Function(string s, int i)  // 5-ci overloading.
        {
            Console.WriteLine(s + i);
        }

        static void Function(int i, string s)  // 6-cı overloading.
        {
            Console.WriteLine(i + s);
        }

        static void Function(ref int i, string s) // 7-ci overloading.
        {
            Console.WriteLine(i + s);
        }

        // Overload olunmuş metodlar qaytardığı tipə görə fərqlənə bilməz!
        //static string Function(string s)     // 8-ci overloading.              
        //{
        //    return s;
        //}

        // Overload olunmuş metodlar ancaq ref və out tipli parametrlərə görə fərqlənə bilməzlər!
        //static void Function(out int i, string s) 
        //{
        //    i = 5;
        //    Console.WriteLine(i + s);       // 9-cu overloading.
        //}

        //Proqramın giriş nöqtəsi
        static void Main()
        {
            Function();                  // 1-ci overloading.
            Function("A");               // 2-ci overloading.
            Function(1);                 // 3-cü overloading.
            Function(3.14);              // 4-cü overloading.
            Function("B ", 2);           // 5-ci overloading.
            Function(3, " C");           // 6-cı overloading.

            int variable = 5;
            Function(ref variable, "D"); // 7-ci перегрузка.

            // Delay.
            Console.ReadKey();
        }
    }
}
