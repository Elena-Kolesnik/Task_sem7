// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static System.Console;
Clear();

int [,] GetArray (int m, int n, int minValue, int maxValue)
{
    int [,] result = new int [m, n];
    for (int i = 0; i < m; i ++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i ++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}\t");
        }
        WriteLine();
    }
    
}

Write("Введите кол-во строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(ReadLine()!);
int [,] array = GetArray(rows, cols, 0, 50);
PrintArray(array);
Write("Введите число, которое необходимо найти: ");
int number = int.Parse(Console.ReadLine()!);

bool searchNumber(int[,] array, int number)
{
    bool condition = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
                condition = true;
        }
    }
    return condition;
}
(int i, int j) FindPosition(int[,] array, int number)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            return (i, j);
        }
    }
    return(-1, -1);
}

if (searchNumber(array, number) is true)
    WriteLine($"Число {number} находится в массиве по координнатам: {FindPosition(array, number)}");
else
    WriteLine($"Числа {number} нет в массиве.");