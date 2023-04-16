void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
{
    rectArea = width * height;
    rectPerimetr = (width + height) * 2;
}

//Əgər biz out ilə arqument göndəririksə, onda bu zaman strong type yox, var sözündən istifadə edə bilərik.
GetRectangleData(10, 20, out var area, out var perimetr);

Console.WriteLine($"Duzbucaqlinin sahesi: {area}");       // 200
Console.WriteLine($"Duzbucaqlinin perimetri: {perimetr}");   // 60