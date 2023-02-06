// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Произведение цифр равно = {GetMultNums(num)}");


int GetMultNums(int number)
{
    int Mult=1;
    for (int i = 1; i<=number; i++) Mult = Mult * i;
    return Mult;
}
