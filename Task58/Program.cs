// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

int[,] Multiply(int[,] mat1, int[,] mat2)
{
    int[,] result = new int[mat1.GetLength(0), mat2.GetLength(1)];
    for (int i = 0; i < mat1.GetLength(0); i++) 
    {
        for (int j = 0; j < mat2.GetLength(1); j++) {
            
            for (int k = 0; k < mat1.GetLength(0); k++)
                result[i,j] += mat1[i,k] * mat2[k,j];
        }
    }
    return result;
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");
int[,] matrix1 = FillArray(rows, columns, 0, 5);
Console.WriteLine();
int[,] matrix2 = FillArray(rows, columns, 0, 5);
Console.WriteLine("Произведение двух матриц: ");
int[,] result = Multiply(matrix1, matrix2);
PrintArray(result);




