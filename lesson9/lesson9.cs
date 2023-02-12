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

// int SumNums(int M, int N)
// {
//     if (N <= M)
//         return N;
//     else
//     return N + SumNums(M, N - 1);
// }

// Console.Write("Введите значение начала отсчёта: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение конца отсчёта: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if (M < N) Console.Write($"Сумма {SumNums(M, N)}");
// else Console.Write($"{M} меньше {N} (Ошибка)");


// #
// Задача 3
//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int A(int m, int n)
{
    if (m == 0) 
        return n + 1;

    if (m != 0 && n == 0) 
        return A(m - 1, 1);

    if (m > 0 && n > 0) 
        return A(m - 1, A(m, n - 1));
        
    return A(m, n);
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(A(m, n));