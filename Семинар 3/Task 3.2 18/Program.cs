// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int quad = int.Parse(Console.ReadLine());

if (quad <= 0 || quad >4 ) Console.WriteLine("не является номером четверти");
else if (quad == 1) Console.WriteLine("x>0 и y>0");
else if (quad == 2) Console.WriteLine("x<0 и y>0");
else if (quad == 3) Console.WriteLine("x<0 и y<0");
else if (quad == 4) Console.WriteLine("x>0 и y<0");
