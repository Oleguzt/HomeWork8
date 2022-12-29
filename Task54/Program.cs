// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
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
            Console.Write($"{array[i, j]} ");
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

int[,] SortingPosition (int[,] array)
{
    int temp;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if (array[row, j] < array[row, j + 1])
                {
                temp = array[row, j];
                array[row, j] = array[row, j + 1];
                array[row, j + 1] = temp;
                }
            }
        }
    }
    return array;
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");
int[,] matrix = FillArray(rows, columns, 0, 48);
Console.WriteLine("Результат после выполнения пузырьковой сортировки:");
matrix = SortingPosition(matrix);
PrintArray(matrix);





