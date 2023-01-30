// Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();
Console.WriteLine("Введите два числа: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int max=0;
int sqr=0;
int num=0;
if (number2>max) 
{
    sqr = number2;
    num = number1;
}
else 
{
    sqr = number1;
    num = number2;
}

Console.WriteLine($"{sqr}, {num}");

if (sqr == Math.Sqrt(num))
{
    Console.WriteLine($"Ваше число {sqr} является квадратом {num}");
}
else
{
    Console.WriteLine($"Ваше число {sqr} НЕ является квадратом {num}");
}