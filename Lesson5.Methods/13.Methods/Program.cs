public class Program
{
    public static void Main()
    {
        int summand1 = 2, summand2 = 3;

        int sum = Add(summand1, summand2);

        Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);
    }

    /// <summary>
    /// İki natural ədədin cəmini toplayan metoddur.
    /// </summary>
    /// <param name="summand1">Birinci ədəd</param>
    /// <param name="summand2">İkinci ədəd</param>
    /// <returns>İki ədədin cəmi</returns>
    static int Add(int summand1, int summand2)
    {
        return summand1 + summand2;
    }

}