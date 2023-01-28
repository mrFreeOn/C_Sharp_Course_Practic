/*Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.*/
void schet()
{
    Console.WriteLine("Введите количество чисел которые будут вводиться: ");
    int M = int.Parse(Console.ReadLine());
    double num;
    int count = 0;
    for(int i = 1; i <= M; i++)
    {
        Console.Write($"Введите {i} число: ");
        num = double.Parse(Console.ReadLine());
        if (num > 0) count++;
    }
    Console.WriteLine($"Количество введенных чисел больше 0: {count}");
}
schet();