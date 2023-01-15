int[] FillArray(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SumNum(int[] arr12)
{
    int value1, value2;
    value1 = value2 = 0;

    for (int i = 0; i < arr12.Length; i++)
    {
        if (arr12[i] >= 0)
            value1 += arr12[i];
        else
            value2 += arr12[i];
    }
    Console.WriteLine($"Сумма положительных элементов: {value1}; Cумма отрицательных элементов: {value2}.");
}
Console.WriteLine("Введите количество элементов массива и диапазон: ");
int[] arr_1 = FillArray(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintArray(arr_1);
SumNum(arr_1);
