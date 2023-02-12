// ДОМАШНИЕ ЗАДАНИЯ 9 УРОКА

// Задача 1
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void NaturalNums(int N)
// {
//     if (N == 1) 
//     {
//         Console.Write(N);
//     }
//     else
//     {
//         Console.Write($"{N}, ");
//         NaturalNums(N - 1);
//     }
// }

// Console.Write("Введите значение N:");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N >= 1) NaturalNums(N);
// else Console.Write($"{N} меньше 1 (Ошибка)");


// #
// Задача 2
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNums(int M, int N)
{
    if (N <= M)
        return N;
    else
    return N + SumNums(M, N - 1);
}

Console.Write("Введите значение начала отсчёта: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение конца отсчёта: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < N) Console.Write($"Сумма {SumNums(M, N)}");
else Console.Write($"{M} меньше {N} (Ошибка)");