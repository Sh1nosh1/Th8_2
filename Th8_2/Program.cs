using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Th8_2
{
    internal class Program
    {
        //Task 1
        //Write a method that "draws" a horizontal line of 60 symbols "*" on the screen.

        /*public static void Func()
        {
            Write('*');
        }*/


        //Task 2
        //Write a method that "draws" a rectangular triangle of the specified form:

        /*public static void Func()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Write("#");
                }
                WriteLine();
            }
        }*/


        //Task 3
        //Calculate the value of the expression by determining and using the complementary method:

        /*public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }*/


        //Task 4
        //Finding the maximum value of two integer variables a, b.

        /*public static double Calculate(int x)
        {
            return (Math.Sqrt(x) + x) / 2;
        }*/


        static void Main(string[] args)
        {
            try
            {
                //Task 1
                //Write a method that "draws" a horizontal line of 60 symbols "*" on the screen.

                /*for (int i = 0; i < 60; i++)
                {
                    Func();
                }*/


                //Task 2
                //Write a method that "draws" a rectangular triangle of the specified form:

                /*Func();*/


                //Task 3
                //Calculate the value of the expression by determining and using the complementary method:

                /*Write($"{Calculate(5)+Calculate(12)+Calculate(19):f2}");*/


                //Task 4
                //Finding the maximum value of two integer variables a, b.

                /*Write("Enter a: ");
                int a = Convert.ToInt32(ReadLine());
                Write("Enter b: ");
                int b = Convert.ToInt32(ReadLine());
                int max = Max(a, b);
                Write($"Maximum value: {max}");*/


            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
