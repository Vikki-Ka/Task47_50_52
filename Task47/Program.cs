/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9    */

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

double[,] GetRandomArray(int col, int row, int start, int end)
{
    int ratio = 100;
    double[,] array = new double[col, row];
    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
        {
            array[i, j] = new Random().Next(start*ratio, (end + 1)*ratio) / (ratio + 0.0);
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
        {
            printInColor(j + "\t", ConsoleColor.DarkYellow);
        }
        Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkRed);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int col = GetUserData("Ввидите количество строк: ");
int row = GetUserData("Ввидите количество столбцов: ");
double[,] arr = GetRandomArray(col, row, 1, 10);
Print2DArray(arr);