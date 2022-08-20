void FillArray(int[,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}

void FillArray2(double[] array, double startNumbered = -99, double finishNumbered = 99)
{ 
    finishNumbered++;
    int size = array.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((random.NextDouble() * (finishNumbered - startNumbered) + startNumbered), 2);  
    }  
}

void PrintArray(int[,] array) 
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

    // void ReversArray()
    // {
    //     if (array.GetLength(0) == array.GetLength(1));
    //     {
    //         for (int i = 0; array.GetLength(0); i++)
    //         {
    //             for (int j = 0; j < array.GetLength(1); j++) 
    //             {
    //                 int temp = Convert.ToInt32(array[0, j]);
    //                 array[0, j] = array[row - 1, j];
    //                 array[row - 1, j] = temp;
    //             }   
    //         }
    //     }         
    // }


/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

7 4 2 1

9 5 3 2

8 4 4 2   */

    void Task54()
    {
        Random random = new Random();
        int rows = random.Next(4,4);
        int columns = random.Next(4,4);
        int[,] array = new int[rows, columns]; 
        FillArray(array);
        PrintArray(array);
        Console.WriteLine();
        int min = array[rows - (rows - 1), columns - (columns - 1)];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns - 1; j++)
            {
                for (int k = 0; k < columns - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k];
                        array[i, k] = array[i, k + 1];
                        array[i, k + 1] = temp;
                    }
                }      
            }
        PrintArray(array);    
    }

    //Task54();

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка  */

 void Task56()
    {
        Random random = new Random();
        int rows = random.Next(4,4);
        int columns = random.Next(4,4);
        int[,] array = new int[rows, columns]; 
        FillArray(array);
        PrintArray(array);
        Console.WriteLine(); 
        int keepSum = Int32.MaxValue;
        int numberString = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j]; 
            }    
            if (sum < keepSum) 
            {
                int temp = keepSum;
                keepSum = sum;
                sum = temp; 
                numberString++;        
            }  
            sum = 0;                                
        } 
        Console.WriteLine($"{numberString} строка");  
    }

    //Task56();

    // Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.

    void Task58()
    {
        int rows = 4;
        int columns = 4;
        int[,] array = new int[rows, columns]; 
        int row = 0;
        int column = 0;
        int changeRow = 0;
        int changeColumn = 1;
        int steps = columns;
        int turn = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[row, column] = i + 1;
            //Console.Write($"{array[row, column]}+\t");
            steps--;
            if (steps == 0)
            {
                steps = rows - 1 - turn/2;
                int temp = changeRow;
                changeRow = changeColumn;
                changeColumn = -temp;
                turn++;
            }

            row += changeRow;
            column += changeColumn;
        }
        PrintArray(array);
    }

    Task58();


   
  