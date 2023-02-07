// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Введите трехзначное число.");
//     while(true)
//     {
//     var input = Console.ReadLine();
//     if( ! input.Equals("exit"))
//     Console.WriteLine("{0}->{1}",input, input[1]);
//      else
//      break;
//     }



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// Console.Write("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// if (ThirdDigit(number1) == -1)
// Console.WriteLine("Третьей цифры нет");
// else
// Console.WriteLine($"Третья цифра {ThirdDigit(number1)}");
// int ThirdDigit(int number)
// {
//  int result = -1;
// if (number >= 100)
//  {
//  while (number > 999)
// {
//  number = number / 10;
//  }
//  result = number % 10;
// }
//  return result; 
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

//  Console.Write(" Нужно узнать, является ли этот день выходным или нет?  "); 
//  while (true) 
//  { 
//  Console.Write("\n Введите номер дня недели  "); 
//  int num = int.Parse(Console.ReadLine()); 
//  if (num >= 1 && num <= 5) 
//   { 
//  Console.Write(" Нет, это не выходной"); 
// } 
// else if (num >= 6 && num <= 7) 
//  { 
//  Console.Write(" Да, это выходной"); 
//  } 
// else Console.Write(" Не существует такого дня недели"); 
//  } 






// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// void CheckPalindromicNumber(int number)
// {
// if(number >= 10000)
//  {
// int division1 = number / 10000;
//  int remainder1 = number % 10;
// if(division1 == remainder1)
// {
// number = number / 10;
// int division2 = (number / 100) % 10;
// int remainder2 = number % 10;
// if(division2 == remainder2)
// Console.WriteLine("Да");
// }
//  else 
//  Console.WriteLine("Нет");
            
//  }
// else
//  Console.WriteLine("Некорректное число!");
// }
 
// Console.WriteLine("Введите пятизначное число:");
// int number = int.Parse(Console.ReadLine()!);
// CheckPalindromicNumber(number);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// using System;
// namespace New_Project
// { class Program
// { public static void Main()
// { double [] x = new double [6];
// double d, distance = 0.0;
// Console.WriteLine("x1 y1 z1 x2 y2 z3: Числа записывать через пробел");
// var line = Console.ReadLine().Split();
// for (int i = 0; i < 3; i++)
// { d = Convert.ToDouble(line[i + 3])
// - Convert.ToDouble(line[i]);
// distance += d * d; }
// Console.WriteLine("r = " + Math.Sqrt(distance)); } } }


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}



// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}