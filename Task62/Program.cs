// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
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

int[,] FillArray(int m, int n) 
{
    int iBegin = 0, iEnd = 0, jBegin = 0, jEnd = 0;
    int k = 1, i = 0 , j = 0;
    int[,] array = new int[m, n];
    while (k <= m * n)
    {
        if (i == iBegin && j < n - jEnd -1)
        {
            array[i, j] = k;
            j++;
        }
        else
        {
            if (j == n - jEnd - 1 && i < m - iBegin - 1)
            {
                array[i, j] = k;
                i++;
            }
            else
            {
                if (i == m - iBegin - 1 && j > jEnd )
                {
                    array[i, j] = k;
                    j--;
                }
                else
                {
                    array[i, j] = k;
                    i--;
                }               
            }
        }
        if ((i == iBegin + 1) && (j == jBegin) && (jBegin != n - jBegin - 1))
        {
            iBegin++;
            iEnd++;
            jBegin++;
            jEnd++;        
        }
        k++;
    }
    return array;
}


int m = 4, n = 4;
PrintArray(FillArray(m, n));
