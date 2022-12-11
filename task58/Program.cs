/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


Console.WriteLine("Введите размерность первой матрицы m x n");
Console.Write("Введите  m: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int [,] matrix1 = new int [m1,n1];
for (int i = 0; i < m1; i++)
{
    for (int j = 0; j < n1; j++)
    {
        matrix1[i,j] = new Random().Next(0,11);
        Console.Write(matrix1[i,j]+ " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Введите размерность второй матрицы m x n");
Console.Write("Введите  m: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int [,] matrix2 = new int [m2,n2];
for (int i = 0; i < m2; i++)
{
    for (int j = 0; j < n2; j++)
    {
        matrix2[i,j] = new Random().Next(0,11);
        Console.Write(matrix2[i,j]+ " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int [,] matrixResult = new int [m1,n2];

if (n1 != m2)
{
    Console.WriteLine("Чтобы можно было умножить две матрицы,");
    Console.WriteLine("количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
}
else 
{
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            matrixResult[i,j] = 0;
            for (int k = 0; k < n1; k++)
            {
                matrixResult[i,j] = matrixResult[i,j]+ matrix1[i,k] * matrix2[k,j];
            }
            Console.Write(matrixResult[i,j]+ " ");
        }
        Console.WriteLine();
    }
}