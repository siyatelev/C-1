// Задача 33/2: Задайте массив. Напишите программу, позволяющую угадать с третьей попытки число которое есть в массиве.


Console.Clear();
int size = InputNumber("Введите размер массива:");
int max = InputNumber("Введите максимальный элемент массива:");
int min = InputNumber("Введите минимальный элемент массива:");
int try = InputNumber("Угадай число, которое есть в массиве:");



int[] array = GetArray(size, min, max);

Console.WriteLine($"{String.Join(",", array)}");

if (CheckArrayNum(array, num)) Console.WriteLine($"число {num} присутствует в массиве"); else Console.WriteLine($"число {num} не присутствует в массиве");

int InputNumber(string message)
{
    Console.Write($"{message} ");
    int res = int.Parse(Console.ReadLine());
    return res;
}

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

bool CheckArrayNum(int[] someArray, int checkNum)
{
    bool flag= false;
    for(int i=0;i<someArray.Length; i++) if (someArray[i] == checkNum) flag = true;
    return flag;
}