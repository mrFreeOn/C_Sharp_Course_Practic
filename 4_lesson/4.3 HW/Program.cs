// Напишите цикл который принмиает на вход два числа А и Б и возводит число А в натуральную степень Б

/* double POW(int num, int p)
{
    return Math.Pow(num, p);
} */

double POW(int num, int p)
{
    double n_pow = 1;
    int p_abs = Math.Abs(p);
    for (int i = 1; i <= p_abs; i++)
    {
        if (p > 0)
            n_pow *= num;
        else
            n_pow /= num;
    }
    return n_pow;
}
Console.WriteLine("Enter a number: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a degree og number: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine(POW(A, B));