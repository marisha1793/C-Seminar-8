/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка*/

Console.WriteLine("Задан двумерный массив:");
int[,] array = Create2DArray(4,4);
Print2DArray(array);
int minSumRow = GetMinSumOfRow(array);
Console.WriteLine($"В строке № {minSumRow} минимальная сумма элементов");


int GetMinSumOfRow(int[,] array)
{
    int[] arraySum = new int [array.GetLength(0)];
    int index = 0; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];  
        }
        if(index < array.GetLength(0))
        {
            arraySum[index] = sum;
            sum = 0;
            index++;
        } 
    }
    
    int minSum = arraySum[0];
    int minSumRow = 1;
    for(int k = 0; k < arraySum.Length; k++)
    {
        if(arraySum[k] < minSum)
        {
            minSum = arraySum[k];
            minSumRow = k + 1;
        }

    }
    
    return minSumRow;
}


void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m,n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }

    return array;
}