// ДОМАШНИЕ ЗАДАНИЯ 6 УРОКА


// Задача 1
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountInArrayMax0(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

int[] NewMetod1(string numss)
{
    string[] arraynumsstring = numss.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
    int[] arraynumsint = arraynumsstring.Select(Int32.Parse).ToArray();
    return arraynumsint; 
}

Console.Write($"Введите значения через пробел :");
string numss = Console.ReadLine() ?? string.Empty;;
int[] arraynumsint = NewMetod1(numss);
Console.WriteLine($"Количество чисел больше 0 = {CountInArrayMax0(arraynumsint)}");