void MethodWihInnderMethod()
{
    Console.WriteLine("Outer method");

    void InnerMethod()
    {
        Console.WriteLine("Inner Metod");
    }

    InnerMethod();
}

MethodWihInnderMethod();

Console.WriteLine("Done!\n");