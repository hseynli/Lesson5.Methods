(string, string) ReturnMultipleResult(string name)
{
    return ($"Your name is {name}", $"Hello, {name}");
}

(string yourNameIs, string greeting) result = ReturnMultipleResult("Farid");

Console.WriteLine(result.yourNameIs);
Console.WriteLine(result.greeting);

Console.WriteLine("Done!\n");