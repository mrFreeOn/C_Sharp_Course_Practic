void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] FillArray(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

int[] Search(int[] arr)
{
    int size = arr.Length;
    int flex_size = size / 2 + size % 2;
    int[] result = new int[flex_size];

    for (int i = 0; i < size / 2; i++)
        result[i] = arr[i] * arr[size - i - 1];

    if (result[flex_size - 1] == 0)
        result[flex_size - 1] = arr[flex_size - 1];
    return result;
}

Console.WriteLine("Введите количество элементов массива и диапазон: ");
int[] arr_1 = FillArray(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintArray(arr_1);
PrintArray(Search(arr_1));

