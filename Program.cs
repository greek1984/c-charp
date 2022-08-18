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



/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9  */

void Task47()

    {
        Random random = new Random();
        int m = random.Next(4,4);
        int n = random.Next(4,4);
        double[,] array = new double[m,n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = Math.Round((random.NextDouble() * 100 - 50), 2);
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }

Task47();


/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */


void Task50()

    {
        Random random = new Random();
        int rows = random.Next(5,5);
        int columns = random.Next(5,5);
        int[,] array = new int[rows,columns];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine("Задайте номер позиции в строке: ");
        int rowPosition = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Задайте номер позиции в ряду: ");
        int columnPosition = Convert.ToInt16(Console.ReadLine());
        if (rowPosition > rows || columnPosition > columns) 
        Console.WriteLine("Такого элемента нет в массиве");
        for (int i = 0; i < rows; i++)
        {
            if (i == rowPosition) rowPosition = i;
        }
        for (int j = 0; j < columns; j++)
        {
            if (j == columnPosition) columnPosition = j; 
                   
        }
        Console.WriteLine(array[rowPosition, columnPosition]);     
    }
    
// Task50();

/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

void Task52()

    {
        Random random = new Random();
        int rows = random.Next(3,3);
        int columns = random.Next(3,3);
        int[,] array = new int[rows,columns];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine();
        double sum = 0;
        double avr = 0;
        for (int j = 0; j < columns; j++)
        {
            for (int i = 0; i < rows; i++)
            {  
                sum += array[i, j];   
            } 
            avr = Math.Round(sum / rows, 2);
            Console.Write(avr + "; ");
            sum = 0;
        } 
        Console.Write("\b\b.");  
    }

//Task52();

