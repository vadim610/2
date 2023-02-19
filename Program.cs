// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



// Console.Write("Введите размер массива: ");
// int length = int.Parse(Console.ReadLine()!);
// Console.Write("Введите минимальное значение массива: ");
// int min = int.Parse(Console.ReadLine()!);
// Console.Write("Введите максимальное значение массива: ");
// int max = int.Parse(Console.ReadLine()!);
// int[] Array = GetArray(length, min, max);
// Console.WriteLine($"[{string.Join(", ", Array)}]");
// FindEven(Array);

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     Random rnd = new Random();// переменная генератор случайных чиселint[] 
//     int[] result = new int[size];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = rnd.Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// void FindEven(int[] MyArray)
// {
//     int even = 0;
//     for (int i = 0; i < MyArray.Length; i++)
//     {
//         if (MyArray[i] % 2 == 0)
//         {
//             even = even + 1;
//         }
//     }
//     Console.WriteLine($"Чётных чисел {even}");
// }




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.Write("Введите размер массива: ");
// int length = int.Parse(Console.ReadLine()!);
// Console.Write("Введите минимальное значение массива: ");
// int min = int.Parse(Console.ReadLine()!);
// Console.Write("Введите максимальное значение массива: ");
// int max = int.Parse(Console.ReadLine()!);
// int[] Array = GetArray(length, min, max);
// Console.WriteLine($"[{string.Join(", ", Array)}]");
// FindOdd(Array); int[] GetArray(int size, int minValue, int maxValue)
// {
//     Random rnd = new Random(); // переменная генератор случайных чисел
//     int[] result = new int[size];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = rnd.Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// void FindOdd(int[] MyArray)
// {
//     int odd = 0;
//     for (int i = 1; i < MyArray.Length; i = i + 2)
//     {
//         odd = odd + MyArray[i];
//     }
//     Console.WriteLine($"Сумма чисел на нечётных позициях {odd}");
// }




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(length, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]");
FindDifference(Array, max, min);
int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random(); // переменная генератор случайных чисел
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}
void FindDifference(int[] MyArray, int minVal, int maxVal)
{
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i] < minVal)
        {
            minVal = MyArray[i];
        }
        if (MyArray[i] > maxVal)
        {
            maxVal = MyArray[i];
        }
    }
    Console.WriteLine($"Разница {maxVal - minVal}");
}