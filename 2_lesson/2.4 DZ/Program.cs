// напишите программу которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого
// числа. Пример: 456 > 5...

int NumberTwo (int num)
{
    Console.WriteLine(num);
    return num % 100 / 10;     
}

Console.WriteLine(NumberTwo(new Random().Next(100,1000)));