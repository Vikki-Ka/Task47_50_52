/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

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

int FindElementInArray(int[,] array, int indexCol, int indexRow)
{
    int findNumber = -99999999;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == (indexCol - 1) && j == (indexRow - 1))
            {
                findNumber = array[i, j];
            }

        }
    }
    return findNumber;
}

int col = GetUserData("Ввидите число строк: ");
int row = GetUserData("Ввидите число столбцов: ");
int[,] arr = GetRandomArray(col, row, 0, 10);
int indexC = GetUserData("Ввидите номер строки: ");
int indexR = GetUserData("Ввидите номер столбца: ");
Print2DArray(arr);
int findUser = FindElementInArray(arr, indexC, indexR);
if (findUser != -99999999)
{
    Console.WriteLine($"Значение элемента в позиции [{indexC},{indexR}] равно {findUser}");
}
else Console.WriteLine($"такой позиции [{indexC},{indexR}] в массиве нет");
