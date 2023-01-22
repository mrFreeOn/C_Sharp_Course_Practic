// наишите программу, которая перевернет одномерный массив 
//(последний элемент удет на первом месте, а первый на последнем и т.д.)


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

void ReversMass(int[] arr_1)
{
    int size = arr_1.Length;
    
    for (int i = 0; i < size / 2; i++)
        (arr_1[i], arr_1[size - i - 1]) = (arr_1[size - i - 1], arr_1[i]);
    
}

Console.WriteLine("Введите количество элементов массива и диапазон: ");
int[] arr_1 = FillArray(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintArray(arr_1);
ReversMass(arr_1);
PrintArray(arr_1);

