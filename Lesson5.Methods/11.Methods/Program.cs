class Program
{
    static void Sum(int a = 0, int b = 0)
    {
        Console.WriteLine(a + b);
    }

    static void Sum(int a = 0, int b = 0, int c = 0)
    {
        Console.WriteLine(a + b + c);
    }

    static void Main(string[] args)
    {
        //Sum();  // Qeyri-müəyyənlik, bilmir hansı metodu çağırsın
        //Sum(1); // Qeyri-müəyyənlik, bilmir hansı metodu çağırsın

        Sum(1, 2);
        Sum(1, 2, 3);

        // Delay
        Console.ReadKey();
    }
}