// ДОМАШНИЕ ЗАДАНИЯ 7 УРОКА

// Задача 1
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

double RandomNums()
{
    double nums = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 1);
    return nums;
}

int m = 3;
int n = 4;
Console.WriteLine("Двумерный массив, случайных чисел: ");
double[,] array = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = RandomNums();
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}