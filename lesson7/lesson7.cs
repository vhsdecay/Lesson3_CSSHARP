// ДОМАШНИЕ ЗАДАНИЯ 7 УРОКА

// Задача 1
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// double RandomNums()
// {
//     double nums = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 1);
//     return nums;
// }

// int m = 3;
// int n = 4;
// Console.WriteLine("Двумерный массив, случайных чисел: ");
// double[,] array = new double[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = RandomNums();
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 2
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.WriteLine("Двумерный массив случайных чисел: ");

// Random random = new Random();
// int[,] array = new int[new Random().Next(4, 10), new Random().Next(4, 10)];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 100);
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите значение для поиска: ");
// int searchElement = Convert.ToInt32(Console.ReadLine());

// int count = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {

//         if (array[i, j] == searchElement && count == 0)
//         {
//             Console.Write($"{searchElement} находится в {i + 1} строке {j + 1} столбце");
//             count += 1;
//         }
//         else if(array[i, j] == searchElement)
//         {
//             Console.Write($"; {i + 1} строке {j + 1} столбце");
//         }
//     }
// }
// if (count < 1) Console.Write($"{searchElement} отсутствует в массиве");


// Задача 3 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Двумерный массив случайных чисел: ");

int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.Write($"Среднее арифметическое столбцов: ");
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, j];
    }
    sum = sum / array.GetLength(1);
    Console.Write($"{j + 1} = {sum}; ");
}