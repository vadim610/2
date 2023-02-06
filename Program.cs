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

 Console.Write(" Нужно узнать, является ли этот день выходным или нет?  "); 
 while (true) 
 { 
 Console.Write("\n Введите номер дня недели  "); 
 int num = int.Parse(Console.ReadLine()); 
 if (num >= 1 && num <= 5) 
  { 
 Console.Write(" Нет, это не выходной"); 
} 
else if (num >= 6 && num <= 7) 
 { 
 Console.Write(" Да, это выходной"); 
 } 
else Console.Write(" Не существует такого дня недели"); 
 } 
