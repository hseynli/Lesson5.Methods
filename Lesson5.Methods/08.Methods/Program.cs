int MethodWihInnderMethod(int number)
{
    number++;
    Console.WriteLine($"number: {number}");

    int InnerMethod(int number)
    {
        number++;
        Console.WriteLine($"number: {number}");
        return number;
    }

    return InnerMethod(number);
}

int number = MethodWihInnderMethod(0);

Console.WriteLine($"Result is: {number}");
Console.WriteLine("Done!\n");