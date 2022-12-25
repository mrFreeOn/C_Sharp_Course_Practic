// напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2Д пространстве

double Distance(int x1, int y1, int x2, int y2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return result;
}
Console.WriteLine(Math.Round(Distance(3,6,2,1)), 2);