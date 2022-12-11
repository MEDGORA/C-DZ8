/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06         
10 09 08 07 */

int[,] matrix = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0; 

while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{   
  matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

for (int k = 0; k < matrix.GetLength(0); k++)
{
  for (int o = 0; o < matrix.GetLength(1); o++)
  {
    if (matrix[k,o] < 10)
    {
      Console.Write($"0{matrix[k,o]} ");
    }
  else 
    {
      Console.Write($"{matrix[k,o]} ");
    }
  }
  Console.WriteLine();
}