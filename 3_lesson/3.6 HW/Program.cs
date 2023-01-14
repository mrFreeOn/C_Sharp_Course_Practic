// напишите программу, которая принимает на вход координаты трех точек и находит расстояние между ними в 
// 3Д пространстве
int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result;
    result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
    return result;
}
int x1; int y1; int z1; int x2; int y2; int z2;
Console.WriteLine(x1 = ReadNumber("Введите координату x1: "));
Console.WriteLine(y1 = ReadNumber("Введите координату y1: ")); 
Console.WriteLine(z1 = ReadNumber("Введите координату z1: "));
Console.WriteLine(x2 = ReadNumber("Введите координату x2: "));
Console.WriteLine(y2 = ReadNumber("Введите координату y2: "));
Console.WriteLine(z2 = ReadNumber("Введите координату z2: "));

Console.WriteLine(Distance(x1, y1, z1, x2, y2, z2));

