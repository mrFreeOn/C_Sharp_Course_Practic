// Напишите программу которая задает массив из 8 элементов случайными числами и выводит их на экран. 
//в виде 2х функций! 

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);
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

int[] arr_1 = FillArray(int.Parse(Console.ReadLine()));
PrintArray(arr_1);
int[] arr_2 = FillArray(int.Parse(Console.ReadLine()));
PrintArray(arr_2);