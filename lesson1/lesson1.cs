// ДОМАШНИЕ ЗАДАНИЯ 1 УРОКА

// Задача 1 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое значение: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write($"Значение {a} больше {b}");
}
else
{
    Console.Write($"Ззначение {b} больше {a}");
}