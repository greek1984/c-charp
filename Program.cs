    void PrintArray(int[] array)
    {
        int size = array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        } 
        Console.WriteLine ();
    }

    void FillArray(int[] array, int startNumber = -999, int finishNumber = 999)
    {
        finishNumber++;
        int size = array.Length;
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(startNumber, finishNumber);
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


/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3  */

    void Task41()

    {
        Console.WriteLine("Введите число 1: ");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число 2: ");
        int numberTwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число 3: ");
        int numberThree = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число 4: ");
        int numberFour = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число 5: ");
        int numberFive = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        if (numberOne > 0) sum++;
        if(numberTwo > 0) sum++;
        if(numberThree > 0) sum++;
        if(numberFour > 0) sum++;
        if(numberFive > 0) sum++;
        Console.WriteLine($"-> {sum}");
    }

    //Task41();

/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) */

    void Task43()

    {

        Console.WriteLine("Введите точку b1: ");
        double numberB1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите точку k1: ");
        double numberK1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите точку b2: ");
        double numberB2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите точку k2: ");
        double numberK2 = Convert.ToDouble(Console.ReadLine());
        double numberX = Math.Round((numberB2 - numberB1)/(numberK1 - numberK2), 2);
        double numberY = Math.Round((numberK1 * numberX + numberB1), 2);
        if (numberK1 == numberK2) Console.WriteLine("Прямые параллельны!");
        else
        {
            Console.WriteLine($"X = {numberX}, Y = {numberY}");
        }

    }

    Task43();