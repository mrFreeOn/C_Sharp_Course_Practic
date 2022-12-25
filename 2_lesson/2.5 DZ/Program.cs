// Напиите программу которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//Пример: 645 > 65...

int DeliteNumberTwo (int num)
{
    Console.WriteLine(num);
    int n1 = num / 100;
    int n2 = num % 10;
    return n1*10 + n2;     
}

Console.WriteLine(DeliteNumberTwo(new Random().Next(100,1000)));