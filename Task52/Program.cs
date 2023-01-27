/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int GetUserData(string massage)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(massage);
    int UserData = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return UserData;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

int[,] GetRandomArray(int col, int row, int start, int end)
{
    int[,] array = new int[col, row];
    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkGreen);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanRow(int[,] array)
{
    int sum = 0;
    double mathMean = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum = sum + array[i, j];
        }
        mathMean = Math.Round(sum / (array.GetLength(1) + 0.0), 2);
        Console.Write(mathMean + ";" + " ");
        sum = 0;
    }
    Console.Write("\b" + "\b" + ".");

}

int col = GetUserData("Ввидите число строк: ");
int row = GetUserData("Ввидите число столбцов: ");
int[,] array = GetRandomArray(col, row, 0, 10);
Print2DArray(array);
ArithmeticMeanRow(array);
