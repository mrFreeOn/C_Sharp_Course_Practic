// наишите программу котораяпринимает на вход (А) и выдает сумму чисел от 1 до А.
// Пример: 7 > 28, 4 > 10, 8 > 36

int SumNums(int num)
{
    int all_sum = 0;
    for (int i = 0; i <= num; i++)
    {
        all_sum += i;
    }

    return all_sum;
}

Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));
