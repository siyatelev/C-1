// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Clear();
Console.WriteLine("Введите два числа: ");
int number1 = int.Parse(Console.ReadLine());
if (number1 % 7 == 0 && number1 % 23 == 0) 
    {
    Console.WriteLine($"число {number1} является кратным 7 и 23");
    }
else
{
    Console.WriteLine($"число {number1}  НЕ является кратным 7 и 23");
}