// Metodların adlı olaraq arqumentlərinin çağrılması

namespace Methods
{
    class Program
    {
        static int Difference(int height, int width)
        {
            return height - width;
        }

        static void Main()
        {
            int difference = Difference(6, 5);
            Console.WriteLine("Iki ededin ferqi: {0}", difference);
            difference = Difference(width: 5, height: 6);

            Console.WriteLine("Iki ededin ferqi: {0}", difference);

            Console.ReadKey();
        }
    }
}
