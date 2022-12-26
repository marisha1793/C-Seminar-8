// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Задан двумерный массив:");
int m = 3;
int n = 4;
int[,] array = Create2DArray(m,n);
Print2DArray(array);
SelectionSort(array);
Console.WriteLine("Массив с отсортированными строками: ");
Print2DArray(array);

void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = 0; x < array.GetLength(1) - 1; x++)
            {
                if (array[i, x] < array[i, x + 1])
                {
                    int temp = array[i, x + 1];
                    array[i, x + 1] = array[i, x];
                    array[i, x] = temp;
                }
            }
        }
    }
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

