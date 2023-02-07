﻿// ДОМАШНИЕ ЗАДАНИЯ 7 УРОКА

// Задача 1
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int[,] arrayRandom = new int[4, 4];

// Console.WriteLine("Двумерный массив случайных чисел: ");
// for (int i = 0; i < arrayRandom.GetLength(0); i++)
// {
//     for (int j = 0; j < arrayRandom.GetLength(1); j++)
//     {
//         arrayRandom[i, j] = new Random().Next(0, 10);
//         Console.Write($"{arrayRandom[i, j]} ");
//     }
//     Console.WriteLine();
// }

// int[,] OrderedRandom = new int[4, 4];

// Console.WriteLine($"Упорядоченный массив по строкам от маскимального: ");
// for (int i = 0; i < arrayRandom.GetLength(0); i++)
// {
//     int jstart = 0;
//     while (jstart < arrayRandom.GetLength(1))
//     {
//         int maxString = arrayRandom[i, jstart];
//         int memory = 0;

//         for (int j = jstart + 1; j < arrayRandom.GetLength(1); j++)
//         {
//             if (maxString < arrayRandom[i, j])
//             {
//                 memory = arrayRandom[i, j];
//                 arrayRandom[i, j] = maxString;
//                 maxString = memory;
//             }
//         }
//         OrderedRandom[i, jstart] = maxString;
//         Console.Write($"{OrderedRandom[i, jstart]} ");
//         jstart++;
//     }
//     Console.WriteLine();
// }


// Задача 2 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int lengthArray = 6;
int widthArray = 4;

int[,] arrayRandom = new int[lengthArray, widthArray];

Console.WriteLine("Прямоугольный двумерный массив случайных чисел: ");
for (int i = 0; i < arrayRandom.GetLength(0); i++)
{
    for (int j = 0; j < arrayRandom.GetLength(1); j++)
    {
        arrayRandom[i, j] = new Random().Next(0, 10);
        Console.Write($"{arrayRandom[i, j]} ");
    }
    Console.WriteLine();
}

int memoryString = 0;
int minSumInString = 0;

for (int i = 0; i < arrayRandom.GetLength(0); i++)
{
    int sumInString = 0;

    for (int j = 0; j < arrayRandom.GetLength(1); j++)
    {
        sumInString += arrayRandom[i, j];
    }

    if (i == 0) 
    {
        minSumInString = sumInString;
    }

    if (minSumInString > sumInString)
    {
        minSumInString = sumInString;
        memoryString = i;
    }
}
Console.WriteLine($"------------------");
Console.WriteLine($"Наименьшая сумма находится в {memoryString + 1} строке");