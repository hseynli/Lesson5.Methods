class Program
{
    static void Method(int a = 0) { Console.WriteLine($"Sadə parameter {a}"); }
    //static void Method(ref int a = 0) { Console.WriteLine($"Ref parameter {a}"); }
    //static void Method(out int a = 0) { a = 3; Console.WriteLine($"Out parameter {a}"); }
    static void Method(in int a = 0) { Console.WriteLine($"In parameter {a}"); }

    static void Main(string[] args)
    {
        Method(1);

        int variable = 2;
        //Qeyri-müəyyənlik (bilinmir hansı metod çağrılmalıdır)
        //Method(ref variable);
        //Method(out variable);
        Method(in variable);

        // Delay
        Console.ReadKey();
    }
}
