// Напишите программу которая принимает на вход число и выдает сумму цифр в числе. 123 > 6, 456 > 15, 66 > 12

int SumNums(int num)
{
    int summ = 0;
    for (int i = num; num != 0; num /= 10)
    {
        summ += num % 10;
    }
    return summ;
}

Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));
