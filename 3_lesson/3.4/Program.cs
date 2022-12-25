// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.

void Pow(int n)
{
    int i = 0;
    while(i < n)
    {
        i++;
        if (i == n)
            Console.Write($" {Math.Pow(i, 2)}.");
        else
            Console.Write($" {Math.Pow(i, 2)},");
    }
}

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
Pow(N);