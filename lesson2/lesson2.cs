// ДОМАШНИЕ ЗАДАНИЯ 2 УРОКА

// Задача 1  
//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write("Введите 3-х значное значенние: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int result = N % 100; 
// result = result / 10;
// Console.WriteLine($"Вторая цифра числа {N} = {result} ");

// Задача 2
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите значение: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= 100)
{
    int result = N;
    while (result > 999)
    {
        result = result / 10;
    }
    result = result % 10;
    Console.WriteLine($"Третья цифра в числе {N} = {result} ");
}
else
{
    Console.WriteLine($"В числе {N} нет третьей цифры");
}