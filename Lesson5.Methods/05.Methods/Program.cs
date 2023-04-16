using System;

// Main() metodundan nəticənin geri qaytarılması.

// Main() metodunu overload etmək mümkündür.

// Proqramın giriş nöqtəsi Main() metodu olmalıdır. Bu metod ya void, ya da int tipli nəticə geriyə qaytarmalıdır.\

namespace Methods
{
    class Program
    {

        // Overload. (Proqramın giriş nöqtəsi deyildir.)
        static string Main(string argument)
        {
            return "Hello " + argument + "!";
        }


        // Proqramın giriş nöqtəsi.
        static int Main()
        {
            string @string = Main("World");

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();

            return 0;
        }
    }
}
