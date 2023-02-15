// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


int num = Input("Введите количество чисел массива:");
int[] array1=FillArr(num);
Console.WriteLine($"{(String.Join(" ",array1))}");
int[] arrayCopy=CopyArr(array1);
Console.WriteLine($"{(String.Join(" ",arrayCopy))}");
Console.WriteLine($"{(String.Join(" ",ExArr(array1,arrayCopy)))}");

int Input(string message)
{
    Console.Write($"{message} ");
    int res = int.Parse(Console.ReadLine());
    return res;
}

int[] FillArr(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,20);
    }
    return arr;
}

int [] CopyArr(int[] array)
{
    int[] copyArray=new int[array.Length];
    for (int i = 0; i < copyArray.Length; i++)
    {
        copyArray[i]=array[i];
    }
    return copyArray;
}

int [] ExArr(int[] array, int[] array2)
{
    int[] array3=new int[array.Length];
    for (int i = 0; i < array3.Length; i++)
    {
        array3[i]=array1[i]*array2[i];
    }
    return array3;
}

