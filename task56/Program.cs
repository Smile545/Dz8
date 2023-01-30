// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.




void Fillmatrix(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(10,100);
        }
    }
}

void Printmatrix(int[,] matrix, int m, int n)
{
    int total = 0;
    int number = 0;
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        total += matrix[0, i];
    }
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
            sum = sum + matrix[i, j];
        }
        if (total > sum)
        {
            total = sum;
            number = i;
        }
        Console.WriteLine();
        Console.WriteLine(sum);
    }
    Console.WriteLine($"Минимальная сумма равна {total} строка {number}");
}


Console.WriteLine("Введите количество строк  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов  ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
Fillmatrix(matrix, m, n);
Printmatrix(matrix, m, n);