// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



Console.Clear();
int size = InputNumber("Введите размер массива:");
int max = InputNumber("Введите максимальный элемент массива:");
int min = InputNumber("Введите минимальный элемент массива:");

int[] array = GetArray(size, min, max);
Console.WriteLine($"{String.Join(",", array)}");
int[] array2 = newArray(array);
Console.WriteLine($"{String.Join(",", array2)}");

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int InputNumber(string message)
{
    Console.Write($"{message} ");
    int res = int.Parse(Console.ReadLine());
    return res;
}



int[] newArray(int[] array)
{
    int [] res = new int[array.Length/2 + array.Length%2];
    for (int i=0; i<res.Length; i++)
    {
        if (i==array.Length-1-i) res[i]=array[i];
        else res[i]=array[i]*array[array.Length-1-i];
    }
    return res;
}









// int[] newArray(int[] someArray)
// {
//     int sizeSomeArray = someArray.Length;
//     int sizeArr;
//     if (someArray.Length % 2 == 0)
//     {
//         sizeArr = someArray.Length / 2;
//         int[] arr = new int[sizeArr];
//         for (int i = 0; i < sizeArr; i++)
//         {
//             arr[i] = someArray[i] * someArray[sizeSomeArray-1 - i];
//         }
    
//     return arr;
//     }
//     else
//     {
//         sizeArr = someArray.Length / 2 + 1;
//         int[] arr = new int[sizeArr];
//         for (int i = 0; i < sizeArr; i++)
//         {
//             if (i<sizeArr-1)
//             {
//                 arr[i] = someArray[i] * someArray[sizeSomeArray-1 - i];
//             }
//             else 
//             {
//                 arr[i] = someArray[i];
//             }
//         }
//     return arr;
//     }
//     Console.WriteLine($"sizeSomeArray = {sizeSomeArray}");
//     Console.WriteLine($"sizeArr = {sizeArr}");
// }


