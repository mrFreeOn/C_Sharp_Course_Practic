// Напишите программу, которая будет принимать на вход 2 числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно 1, то  программа выводит остаток от деления. 
// Пример: 34, 5 > не кратно, остаток 4; 16, 4 > кратно

string Multiplicity (int arg1, int arg2)
{
    if (arg1 % arg2 != 0)
        return $"не кратно, остаток {arg1 % arg2}";
    else
        return $"кратно";
}
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(Multiplicity(num1, num2));