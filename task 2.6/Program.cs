﻿//Напишите программу, которая выводит на экран числа от 1 до 100. 
//При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz», 
//а вместо чисел, кратных пяти — слово «Buzz». 
//Если число кратно и 3, и 5, то программа должна выводить слово «FizzBuzz».

Console.Clear();
int index = 1;
while (index <= 100)
{
    if (index % 3 == 0 && index % 5 == 0)
    {
        Console.Write(" FizzBuzz ");
    }
    else if (index % 3 == 0)
    {
        Console.Write(" Fizz ");
    }
    else if (index % 5 == 0)
    {
        Console.Write(" Buzz ");
    }
    else
    {
        Console.Write(" "+index+" ");
    }
index++;
}
Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");