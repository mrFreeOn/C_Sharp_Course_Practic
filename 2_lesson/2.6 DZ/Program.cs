// Напиите программу которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Пример: 654 > 4; 78 > третьей цифры нет; 12341 > 3...

void NumberThree(int num)
{
    Console.Write($"{num} -> ");
    if (num < 99)
    {
        Console.WriteLine("there is not third digit");
        return;
    }

    while (num > 999) num /= 10;
    Console.WriteLine(num % 10);
}

NumberThree(int.Parse(Console.ReadLine()));