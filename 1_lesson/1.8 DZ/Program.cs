// Напишите програаму которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.WriteLine("Введите число: ");
var N = int.Parse(Console.ReadLine());

int count = 2;

while (count <= N+1)
{
    if (count % 2 == 0)
    {
        Console.Write($" {count}");
    }
    count += 1;
}