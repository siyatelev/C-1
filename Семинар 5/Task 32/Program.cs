// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


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

int[] ReverseArr(int[] someArr)
{
    int[] res = someArr;
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = -1 * res[i];
    }
    return res;
}


int size = InputNumber("Введите размер массива:");
int max = InputNumber("Введите максимальный элемент массива:");
int min = InputNumber("Введите минимальный элемент массива:");

int[] array = GetArray(size, min, max);
Console.WriteLine($"{String.Join(",", array)}");

ReverseArr(array);
Console.WriteLine();
Console.WriteLine($"{String.Join(",", array)}");
