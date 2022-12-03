// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double ArithmeticMean(int[,] array, double rows, int cols)
{
    double count = 0;
    for (int i = 0; i < cols; i++)
    {
        double sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum += array[j, i];
        }
        count = sum / rows;
        WriteLine($"В столбце {i + 1} среднее арифметическое равно {Math.Round(count, 2)}");
    }
    return count;
}
Write("Введите кол-во строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(ReadLine()!);
int [,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
ArithmeticMean(array, rows, cols);

