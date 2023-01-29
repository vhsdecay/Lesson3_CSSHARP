﻿// ДОМАШНИЕ ЗАДАНИЯ 6 УРОКА


// Задача 1
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int CountInArrayMax0(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }

// int[] NewMetod1(string numss)
// {
//     string[] arraynumsstring = numss.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
//     int[] arraynumsint = arraynumsstring.Select(Int32.Parse).ToArray();
//     return arraynumsint; 
// }

// Console.Write($"Введите значения через пробел :");
// string numss = Console.ReadLine() ?? string.Empty;;
// int[] arraynumsint = NewMetod1(numss);
// Console.WriteLine($"Количество чисел больше 0 = {CountInArrayMax0(arraynumsint)}");


// Задача 2
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");