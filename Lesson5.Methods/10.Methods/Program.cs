//Default dəyərlərli arqumentlər mütləq sonda gəlməlidir!
void MethodWithDefaultValues(int a, int b, int c, int d = 3, int e = 4, int f = 5)
{
    Console.WriteLine($"{a} {b} {c} {d} {e} {f}");
}

MethodWithDefaultValues(0, 1, 2);