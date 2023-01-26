// ДОМАШНИЕ ЗАДАНИЯ 1 УРОКА

// Задача 1 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Введите первое значение: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе значение: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// {
//     Console.Write($"Значение {a} больше {b}");
// }
// else
// {
//     Console.Write($"Ззначение {b} больше {a}");
// }

// Задача 2
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Введите первое значение: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе значение: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третие значение: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a < b)
// {
//     Console.Write($"Максимальное число {b}");
// }
// else if (a < c)
// {
//     Console.Write($"Максимальное число {c}");
// }
// else 
// {
//     Console.Write($"Максимальное число {a}");
// }

// Задача 3
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите значение для проверки на чётность: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int x = a % 2; 
// if (x == 0)
// {
//     Console.Write($"Число {a} чётное");
// }
// else
// {
//     Console.Write($"Число {a} не чётное");
// }

// Задача 4
//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите значение: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Все чётные числа от 1 до {N}:");
for (int a = 1; a < N; a++)
{
    if (a % 2 == 0)
    {
        Console.Write($"{a}, ");
    }

}