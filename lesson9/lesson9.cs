// ДОМАШНИЕ ЗАДАНИЯ 9 УРОКА

// Задача 1
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void NaturalNums(int N)
{
    if (N == 1) 
    {
        Console.Write(N);
    }
    else
    {
        Console.Write($"{N}, ");
        NaturalNums(N - 1);
    }
}

Console.Write("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= 1) NaturalNums(N);
else Console.Write($"{N} меньше 1 (Ошибка)");
