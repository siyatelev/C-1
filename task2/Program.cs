// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Clear();
Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine());

//int count = 1;
if(day == 1)
{
Console.WriteLine("понедельник");
}
if(day == 2)
{
Console.WriteLine("вторник");
}
if(day == 3)
{
Console.WriteLine("среда");
}
if(day == 4)
{
Console.WriteLine("четверг");
}
if(day == 5)
{
Console.WriteLine("пятница");
}
if(day == 6)
{
Console.WriteLine("суббота");
}
if(day == 7) Console.WriteLine("воскресенье");
if(day<1) Console.WriteLine("нет такого дня недели");
else if (day>7) Console.WriteLine("нет такого дня недели");
