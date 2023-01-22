// задайте массив вещественных чисел. Найдите разницу между мин и макс элементами массива.

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double[] FillArray(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble()*(from + to) - from,2);
    }
    return arr;
}

void Search(double[] arr)
{
    double Max, Min;
    Max = Min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > Max)
            Max = arr[i];
        if (arr[i] < Min)
            Min = arr[i];
    }
    Console.WriteLine($"Max: {Max}, Min: {Min}");
    Console.WriteLine($"Diff: {Max} - ({Min}) = {Math.Round(Max - Min, 2)}");
}

Console.WriteLine("Введите количество элементов массива и диапазон: ");
double[] arr_1 = FillArray(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintArray(arr_1);
Search(arr_1);

