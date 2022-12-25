// вычислить модуль числа: 6 > 6 ; -82 > 82

Console.WriteLine("Введите число: ");
 int num = int.Parse(Console.ReadLine());
 
 if (num < 0)
 {
    Console.WriteLine ($"{Math.Abs(num)}");
 }
 else
 {
    Console.WriteLine (num);
 }