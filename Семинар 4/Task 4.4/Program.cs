// Задача 30: Напишите программу, 
// которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
int[] array1 = new int[N];
int[] array2 = new int[N];
int[] array3 = new int[N];

NumArray(array1, array2);

SumArray(array1, array2, array3);
Console.WriteLine();

PrintArray(array1);
Console.WriteLine();

PrintArray(array2);
Console.WriteLine();

PrintArray(array3);
Console.WriteLine();

void NumArray(int[] ar1, int[] ar2)
{
    int length = ar1.Length;
    int index = 0;
    while (index < length)
    {
        ar1[index] = new Random().Next(0, 2);
        ar2[index] = new Random().Next(0, 2);
        index++;
    }
}

void SumArray(int[] ar1, int[] ar2, int[] ar3)
{
    int length = ar3.Length;
    int position = 0;
    while (position < length)
    {
        ar3[position] = ar1[position] + ar2[position];
        position++;
    }
}

void PrintArray(int[] arr) 
{
    int count = arr.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write(arr[i]);
        i++;
    }
}

Console.WriteLine($"{String.Join(",", array3)}"); // Вывод строки массива!!!!


