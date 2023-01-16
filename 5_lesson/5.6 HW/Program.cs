// задайте одномерный массив заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.

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

int Search(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i += 2)
        count += arr[i];
    return count;
}

Console.WriteLine("Введите количество элементов массива и диапазон: ");
int[] arr_1 = FillArray(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintArray(arr_1);
Console.WriteLine(Search(arr_1));

