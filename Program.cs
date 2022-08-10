
void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    } 
    Console.WriteLine ();
}

void PrintArray2(double[] array)
{
    int size = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    } 
    Console.WriteLine();
}

void FillArray(int[] array, int startNumber = -10, int finishNumber = 10)
{
    finishNumber++;
    int size = array.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
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

void SortArray(int[] array)

{
    int size = array.Length;
    for (int i = array.Length -1; i > 0; i++)
    {
        for (int k = 0; k > i; k++)
        {
            if (Math.Abs(array[k]) > Math.Abs(array[k+1]))
            {
                int temp = array[k];
                array[k] = array[k+1];
                array[k+1] = temp;
            }
        }
    }  

}

void ReversArray(int[] array)
{
    int size = array.Length;
    int halfSize = size / 2;
    int maxSize = size -1;

    for (int i = 0; i < halfSize; i++)
    {
        int temp = array[i];
        array[i] = array[maxSize -i];
        array[maxSize -i] = temp;
    } 

}


/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

void Task34()

{
    int size = 6;
    int[] array = new int[size];
    FillArray(array, 100,1000); 
    PrintArray(array);
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        sum++;
    }
    Console.WriteLine(sum);
}

Task34(); 

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 24
[-4, -6, 89, 6] -> 85 */

void Task36()

{
    int size = 6;
    int[] array = new int[size];
    FillArray(array, -10,10); 
    PrintArray(array);
    int sum = 0;
    for (int i = 0; i <= size - 1; i++)
    {
        if (i % 2 == 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine(sum);
}

// Task36();

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
[3,21 7,04 22,93 -2,71 78,24] -> 75,53 */

void Task38()

{
    int size = 6;
    double[] array = new double[size];
    FillArray2(array); 
    PrintArray2(array);
    double max = 0;
    double min = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double result = max - min;
    Console.WriteLine(Math.Round(result, 2));
}

//Task38();