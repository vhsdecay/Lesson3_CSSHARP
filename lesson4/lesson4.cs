// ДОМАШНИЕ ЗАДАНИЯ 4 УРОКА

// Задача 1
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число :");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень возведения :");
// int B = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 0; i < B; i++)
// {
//     result = result * A;
// }
// Console.WriteLine($"{A} в степени {B} = {result}");

// Задача 2 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Numsum(int num)
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result = result + (num % 10);
//         num = num / 10;
//     }
//     return result;
// }

// Console.Write("Введите значение :");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма чисел {num} = {Numsum(num)}");

// Задача 3
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] array = new int[8];
Random value = new Random();
Console.Write($"Массив из 8 элементовв ->");
for (int i = 0; i < array.Length; i++)
{
    array[i] = value.Next(0, 100);
    if (i == 7)
    {
        Console.Write($" {array[i]}");
        break;
    }
    Console.Write($" {array[i]} ,");
}
