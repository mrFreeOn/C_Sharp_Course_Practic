/* напишите программу, которая принимает на вход три числа и проверяет, может ли  существовать треугольник 
со сторонами такой длинны. Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы
двух других сторон */


void tryG(int a, int b, int c)
{
    if (a < b + c && b < c + a && c < a + b)
        Console.WriteLine("Yes");
    else 
        Console.WriteLine("No");
}

Console.WriteLine("Введите длины сторон треугольника: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
tryG(a, b, c);


