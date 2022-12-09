/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2   */

Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j]+ " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int [,] array = new int [m,n];
for (int i = 0; i < m; i++)
{
int max = 0;
    for (int j = 0; j < n; j++)
    {
            if (matrix[i,j] > max)
            {
                max = matrix[i,j];
                array[i,0] = max;
            }
        //Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}