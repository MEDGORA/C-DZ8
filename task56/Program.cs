/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


Console.WriteLine("Введите размерность прямоугольного двумерного массива m x m");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;

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

int indexLine = 0;
double min = 30;
double sumLine = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sumLine = sumLine + Convert.ToDouble(matrix[i,j]);
    }
     if (sumLine < min)
        {
            min = sumLine;
            indexLine = i;
        }
    sumLine = 0;
}
Console.WriteLine("Строка с наименьшей суммой элементов: " + (indexLine+1) + " строка");