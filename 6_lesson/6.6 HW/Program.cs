/*Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
y = k1*x+b1, y = k2*x+b2; значения b1, k1, b2, k2 задаются пользователем*/

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double[] P_line(double k1, double b1, double k2, double b2)
{
    double x, y;
    double[] result = new double[2];
    result[0] = -1;
    result[1] = -1;
    if (Math.Abs(b1) == Math.Abs(b2) && Math.Abs(k1) == Math.Abs(k2))
    {
        Console.WriteLine("Прямые не пресекаются");
        return result;
    }
    else
    {   

        x = (b2 - b1) / (k1 - k2);
        result[0] = x;
        result[1] = k1 * x + b1;
        return result;        
    }   
    
}

Console.WriteLine("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int b2 = int.Parse(Console.ReadLine());


Console.Write($"Координаты пересечения прямых: ");
PrintArray(P_line(k1, b1, k2, b2));