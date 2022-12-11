/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


Console.WriteLine("Введите размерность трёхмерного массива m x n x l");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  l: ");
int l = Convert.ToInt32(Console.ReadLine());

int [,,] matrix = new int [m,n,l];
int newDigit = 0;
for (int digit = 10; digit < 100; digit++)
{
    int count = 0;
    for (int k = 0; k < l; k++)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i,j,k] = new Random().Next(10,100);
                if (digit == matrix[i,j,k])
                {
                    count++;
                }
                else if (count == 0)
                {
                    newDigit = digit;
                }
                else if (digit < 99 && count > 1)
                {
                    matrix[i,j,k] = new Random().Next(digit+1,100); 
                }
                else if (digit == 99 && count > 1)
                {
                    matrix[i,j,k] = newDigit;
                }
            }
        }
    }
}

for (int k = 0; k < l; k++)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}