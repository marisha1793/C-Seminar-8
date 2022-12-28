/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.WriteLine("Задано два двумерных массива. Первый массив:");
int[,] array1 = Create2DArray(2,2);
Print2DArray(array1);
Console.WriteLine();
Console.WriteLine("Второй массив:");
int[,] array2 = Create2DArray(2,2);
Print2DArray(array2);
Console.WriteLine();
Console.WriteLine("Результат произведения массивов:");
int[,] array3 = GetMultiplicationOfTwoArray(array1, array2);
Print2DArray(array3);


int[,] GetMultiplicationOfTwoArray(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0),array1.GetLength(1)];
    
    array3[0,0] = array1[0,0] * array2[0,0] + array1[0,1] * array2[1,0];
    array3[1,0] = array1[1,0] * array2[0,0] + array1[1,1] * array2[1,0];
    array3[0,1] = array1[0,0] * array2[0,1] + array1[0,1] * array2[1,1];
    array3[1,1] = array1[1,0] * array2[0,1] + array1[1,1] * array2[1,1];

    return array3;
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