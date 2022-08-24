
/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
M = 1; N = 9. -> "3, 6, 9" M = 13; N = 20. -> "15, 18"  */

using System;

namespace Homework9

{
    class Program
    {
        static void Main(string[] args)
        {

            void Task64(int m, int ternary, int n)
            {
                if (m > n || ternary > n) return; 
                if (ternary >= m) Console.Write(ternary + " ");
                ternary += 3;
                Task64(m, ternary, n);
            }

            void Ternary()
            {
                Console.WriteLine("Введите число M: ");
                int numberM = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число N: ");
                int numberN = Convert.ToInt32(Console.ReadLine());
                int ternary = 0;
                Task64(numberM, ternary, numberN);
            }
            //Ternary(); 


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

            void Task66(int m, int n, int sum)
            {
                if (m > n) 
                {
                    Console.Write($"-> {sum}");
                    return;
                }
                sum += m;
                m++;
                Task66(m, n, sum); 
            } 

            void Sum()
            {
                Console.WriteLine("Введите число M: ");
                int numberM = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число N: ");
                int numberN = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                Task66(numberM, numberN, sum);
            }
            //Sum();

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

            static int Akkerman(int m, int n)
            {
                if (m == 0)
                {
                    return n + 1;
                }
                else if((m > 0) && (n == 0))
                {
                    return Akkerman(m - 1, 1);
                }
                else if((m > 0) && (n > 0))
                {
                    return Akkerman(m - 1, Akkerman(m, n - 1));
                }
                else return n + 1;
            }

            static void Main()
            {
                Console.WriteLine(Akkerman(2, 1));
            }
            Main();
        } 
    }
}