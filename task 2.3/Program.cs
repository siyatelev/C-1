// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Clear();
Console.WriteLine("Введите два числа: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number1%number2 == 0) Console.WriteLine($"число {number2} является кратным {number1}");
else 
{
    Console.WriteLine($"число {number2}  НЕ является кратным {number1}");
    int num = number1%number2;
    Console.WriteLine($"остаток {num}");
}