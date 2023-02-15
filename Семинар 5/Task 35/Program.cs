// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


Console.Clear();
int size = 123;
int max = 220;
int min = 0;
int minNum = 10;
int maxNum = 99;



int[] array = GetArray(size, min, max);

Console.WriteLine($"{String.Join(",", array)}");

Console.WriteLine($"В нашем массиве {CheckArrayNum(array, minNum, maxNum)} чисел, в промежутке [{minNum};{maxNum}]");


int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int CheckArrayNum(int[] someArray, int min, int max)
{
    int Num = 0;
    foreach (int el in someArray)
    {
        if (el >= min && el <= max) Num++;
    }
    return Num;
}
