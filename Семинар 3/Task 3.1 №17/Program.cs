// Задача №17. Напишите программу, 
// которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

Console.Clear();
Console.WriteLine("Введите х: ");
int Х = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y: ");
int Y = int.Parse(Console.ReadLine());

if (X > 0$$Y > 0) Console.WriteLine("1");
if (X < 0$$y > 0) Console.WriteLine("2");
if (x < 0$$y < 0) Console.WriteLine("3");
if (x > 0$$y < 0) Console.WriteLine("4");

