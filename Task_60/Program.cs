/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
 Массив размером 2 x 2 x 2
 66(0,0,0) 25(0,1,0)
 34(1,0,0) 41(1,1,0)
 27(0,0,1) 90(0,1,1)
 26(1,0,1) 55(1,1,1)
 */

int [,,] array;
int [,,] CreateArray()
{

    Random rand = new Random();
    int n = rand.Next(2,3);
    int [,,] array = new int[n, n, n];
    return array;
}





void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})" + "\t");
            }
        }
    }
}


void FillArray(int[,,] arr)
{
    Random rand = new Random();
    int count = rand.Next(10,15);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += rand.Next(3,5);
            }
        }
    }
}

array = CreateArray();
FillArray(array);
PrintArray(array);
Console.WriteLine();