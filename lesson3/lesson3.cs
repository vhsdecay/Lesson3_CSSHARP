// ДОМАШНИЕ ЗАДАНИЯ 3 УРОКА

// Задача 1 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 999 && num < 100000)
// {
//     if(num % 10 == num / 10000 % 10 && num / 10 % 10 == num / 1000 % 10)
//     {
//         Console.WriteLine($"Число {num} является палиндромом");
//     }
//     else
//         Console.WriteLine($"Число {num} не является палиндромом");
// }
// else
//     Console.WriteLine($"Число {num} не является пятизначным");

// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Введите координаты 1 точки");
// Console.Write("х :");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y :");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("z :");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты 2 точки");
// Console.Write("х :");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y :");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("z :");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double result = 0;
// Console.WriteLine(Math.Round(result = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)), 3));

// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число :");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"3 -> "); 
for (int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
}
