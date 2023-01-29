// ДОМАШНИЕ ЗАДАНИЯ 5 УРОКА

// Задача 1
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] RandomArray3()
// {
//     int[] array = new int[5];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void PrintRandomArray(int[] randomarray3)
// {
//     Console.Write($"Рандомный массив трехзначных чисел : [");
//     for (int i = 0; i < randomarray3.Length; i++)
//     {
//         if (i != randomarray3.Length - 1)
//         {
//             Console.Write($"{randomarray3[i]}, ");
//         }
//         else Console.WriteLine($"{randomarray3[i]}]");
//     }
// }

// int[] randomarray3 = RandomArray3();
// PrintRandomArray(randomarray3);
// int countevennum = 0;
// for (int i = 0; i < randomarray3.Length; i++)
// {
//     while (randomarray3[i] != 0)
//     {
//         int evennum = randomarray3[i] % 10;
//         if (evennum % 2 == 0)
//         {
//             countevennum += 1;
//             randomarray3[i] /= 10;
//         }
//         else randomarray3[i] /= 10;
           
//     }
// }
// Console.WriteLine($"Колличество чётных чисел в массиве = {countevennum}");


// Задача 2
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] RandomArray3()
// {
//     int a = new Random().Next(4, 10);
//     int[] array = new int[a];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-99, 100);
//     }
//     return array;
// }

// void PrintRandomArray(int[] randomarray3)
// {
//     Console.Write($"Массив от 4 до 10 случайных значаний: [");
//     for (int i = 0; i < randomarray3.Length; i++)
//     {
//         if (i != randomarray3.Length - 1)
//         {
//             Console.Write($"{randomarray3[i]}, ");
//         }
//         else Console.WriteLine($"{randomarray3[i]}]");
//     }
// }

// int[] randomarray3 = RandomArray3();
// PrintRandomArray(randomarray3);
// int sumevennum = 0;
// for (int i = 0; i < randomarray3.Length; i++)
// {
//     if (i % 2 == 1)
//     {
//         sumevennum += randomarray3[i];
//     }
// }
// Console.WriteLine($"Сумма значений стоящих на нечётных позициях = {sumevennum}");


// Задача 3
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] RandomArray3()
{
    int a = new Random().Next(4, 10);
    int[] array = new int[a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void PrintRandomArray(int[] randomarray3)
{
    Console.Write($"Массив от 4 до 10 случайных значаний: [");
    for (int i = 0; i < randomarray3.Length; i++)
    {
        if (i != randomarray3.Length - 1)
        {
            Console.Write($"{randomarray3[i]}, ");
        }
        else Console.WriteLine($"{randomarray3[i]}]");
    }
}

int MaxValueArray(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

int MinValueArray(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

int[] randomarray3 = RandomArray3();
PrintRandomArray(randomarray3);
int maxrandomarray3 = MaxValueArray(randomarray3);
Console.WriteLine($"Максимальное число массива: {maxrandomarray3}");
int minrandomarray3 = MinValueArray(randomarray3);
Console.WriteLine($"Минимальное число массива: {minrandomarray3}");
Console.WriteLine($"Разница между максимальным и минимальным значением равна: {maxrandomarray3-minrandomarray3}");