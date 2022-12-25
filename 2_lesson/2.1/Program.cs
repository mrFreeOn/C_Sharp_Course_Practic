// напишите программу, которая выводит случайное трехзначное число
// и на выходе показывает последнюю цифру этого числа: 722 > 2, 895 > 5, 314 > 4...

int MaxNumber (int num)
{
    Console.WriteLine(num);
    return num % 10;     
}

Console.WriteLine(MaxNumber(new Random().Next(100,1000)));
