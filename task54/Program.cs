// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.





void Fillmatrix(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(-10,10);
        }
    }
}

void Printmatrix(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Sort(int[,] matrix, int m, int n)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) -1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int sort = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = sort;
                }
            }
        }
    }
}



Console.WriteLine("Введите количество строк  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов  ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
Fillmatrix(matrix, m, n);
Printmatrix(matrix, m, n);
Console.WriteLine();
Sort(matrix, m, n);
Printmatrix(matrix, m, n);
