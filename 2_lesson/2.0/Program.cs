// напишите программу, которая выводит случайное число
// на отрезке [10, 99] показывает наибольшую цифру: 72 > 7, 89 > 9, 31 > 3...

int MaxNumber (int num)
{
    Console.WriteLine(num);

    if (num % 10 > num / 10)
        return num % 10;
    else
        return num / 10;
}

Console.WriteLine(MaxNumber(new Random().Next(10,100)));
