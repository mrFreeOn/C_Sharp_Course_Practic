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

string Search(int[] arr, int N)
{
    string flag = "нет";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == N)
            return "да";
    }
    return "Нет";
}
Console.Write("Введите искомое число: ");
int numSearch = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество элементов массива и диапазон: ");
int[] arr_1 = FillArray(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintArray(arr_1);
Console.WriteLine(Search(arr_1, numSearch));

