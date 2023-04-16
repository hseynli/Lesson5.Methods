//Əgər metod sadəcə bir sətirdən ibarətdirsə, onda biz onu aşağıdakı şəkildə yaza bilərik
void SayHello() => Console.WriteLine("Hello");

string GetMessage() => "hello";

int GetPow(int number) => number * number;

SayHello();

Console.WriteLine(GetMessage());
Console.WriteLine(GetPow(5));