// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



void Fillmatrix(int[,,] matrix, int m, int n, int z)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(-100,100);
            }
        }
    }
}

void Printmatrix(int[,,] matrix, int m, int n, int z)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + " ");
                Console.Write($"({i},{j},{k})");
            }
            Console.WriteLine();
        }
        
    }
}


Console.WriteLine("Введите значения для трехмерного массива  ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[m, n, z];
Fillmatrix(matrix, m, n, z);
Printmatrix(matrix, m, n, z);