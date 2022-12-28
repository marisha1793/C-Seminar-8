/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] array = Create3DArray();
Print3DArray(array);



void Print3DArray(int[,,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var h = 0; h < array.GetLength(2); h++)
            {
                Console.Write($"{array[i,j,h]} ({i},{j},{h}) ");
            }
            Console.WriteLine();
        }
        
    }
}


int[,,] Create3DArray()
{
    int[,,] array = new int[2,2,2];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                int number;
                do
                {
                    number = random.Next(10,100);
                } 
                while (Containts(array, number));
                array[i,j,h] = number;
            }
        }
        
        
    }

    return array;
}

bool Containts(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
              if (array[i,j,h] == number)
              {
                return true;
              }
              
            }
        }
    }  
    return false;        
}


