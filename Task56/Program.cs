// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rows, int columns, int begin, int end)
{
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(begin, end);
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();

    }
    return array;
}

int EnterData(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int FindSumRow (int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int minSumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (i == 0) minSum = sum;
        if (minSum >= sum)
        {
            minSum = sum;
            minSumRow = i + 1;
        }
        sum = 0;
    }
    return minSumRow;
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");
int[,] matrix = FillArray(rows, columns, 0, 10);
int sumRow = FindSumRow(matrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {sumRow}");



