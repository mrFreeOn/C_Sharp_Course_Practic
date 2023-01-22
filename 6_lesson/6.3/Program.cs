/*не используя рекурсию, выведите первые N чисел фибоначи.
Первые два числа фибоначи 0 и 1.*/

void Fibonachi(int x)
{
    int a = 0;
    int b = 1;

    for (int i = 0; i < x; i++)
    {
        Console.Write($"{a} ");
        (a, b) = (b, a + b);
    }
}

Fibonachi(int.Parse(Console.ReadLine()));