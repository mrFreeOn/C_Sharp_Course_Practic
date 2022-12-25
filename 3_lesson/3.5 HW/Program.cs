// напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Пример: 14212 ->  нет, 23432 -> да, 12821 -> да

void Palindrome(int Num)
{
    if (Num < 99999 && Num >9999 )
    {
        if (Num % 10 == Num / 10000 && Num % 100 % 10 == Num / 1000 / 10)
            Console.WriteLine("да");
        else
            Console.WriteLine("нет");
    }

    else
    {
        Console.WriteLine("Error");
    }

}
Console.Write("Введите 5-ти значное число: ");
int Number = int.Parse(Console.ReadLine());
Palindrome(Number);

