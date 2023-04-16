(string, string) ReturnMultipleResult(string name)
{
    return ($"Your name is {name}", $"Hello, {name}");
}

(string, string) result = ReturnMultipleResult("Farid");

Console.WriteLine(result.Item1);
Console.WriteLine(result.Item2);

Console.WriteLine("Done!\n");