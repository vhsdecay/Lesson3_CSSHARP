// ДОМАШНИЕ ЗАДАНИЯ 5 УРОКА

// Задача 1
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] RandomArray3()
{
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintRandomArray(int[] randomarray3)
{
    Console.Write($"Рандомный массив трехзначных чисел : [");
    for (int i = 0; i < randomarray3.Length; i++)
    {
        if (i != randomarray3.Length - 1)
        {
            Console.Write($"{randomarray3[i]}, ");
        }
        else Console.WriteLine($"{randomarray3[i]}]");
    }
}

int[] randomarray3 = RandomArray3();
PrintRandomArray(randomarray3);
int countevennum = 0;
for (int i = 0; i < randomarray3.Length; i++)
{
    while (randomarray3[i] != 0)
    {
        int evennum = randomarray3[i] % 10;
        if (evennum % 2 == 0)
        {
            countevennum += 1;
            randomarray3[i] /= 10;
        }
        else randomarray3[i] /= 10;
           
    }
}
Console.WriteLine($"Колличество чётных чисел в массиве = {countevennum}");